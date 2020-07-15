﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hangfire;
using MHFoodBank.Web.Areas.Volunteer.Pages.Shared;
using MHFoodBank.Web.Data;
using MHFoodBank.Web.Data.Models;
using MHFoodBank.Web.Dtos;
using MHFoodBank.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MHFoodBank.Web.Areas.Volunteer.Pages
{
    [BindProperties]
    public class VolunteerCalendarModel : VolunteerPageModel
    {
        private readonly IMapper _mapper;
        public List<ShiftReadEditDto> AssignedShifts { get; set; }
        public List<ShiftReadEditDto> OpenShifts { get; set; }
        [BindProperty]
        public List<Position> Positions { get; set; }
        public bool AddedShift { get; set; } = false;
        public string StatusMessage { get; set; }
        [BindProperty]
        public int SelectedPositionId { get; set; }
        [BindProperty]
        public DateTime ClickedShiftDate { get; set; }
        [BindProperty]
        public ShiftReadEditDto SelectedShift { get; set; }

        public VolunteerCalendarModel(FoodBankContext context, UserManager<AppUser> userManager, IMapper mapper) : base(userManager, context)
        {
            _mapper = mapper;
        }

        public async Task OnGet(string statusMessage = null)
        {
            StatusMessage = statusMessage;
            await PrepareModelAndGetCurrentVolunteer();
        }

        public async Task<IActionResult> OnPostWorkShift()
        {
            var volunteer = await PrepareModelAndGetCurrentVolunteer();

            Shift selectedShift = _context.Shifts.FirstOrDefault(s => s.Id == SelectedShift.Id);

            await AssignShiftToVolunteer(selectedShift, volunteer);

            return RedirectToPage(new { statusMessage = "You have signed up for the selected shift!" });
        }

        public async Task<IActionResult> OnPostRequestChange()
        {
            string shiftDate = null;

            Shift selectedShift = await _context.Shifts.FirstOrDefaultAsync(s => s.Id == SelectedShift.Id);

            // if the original shift is part of a recurring set, 
            // the RequestChange page needs to know the date of the selected shift
            if (selectedShift is RecurringShift recurringShift)
            {
                shiftDate = ClickedShiftDate.ToString("yyyy-MM-dd");
            }

            return RedirectToPage("RequestChange", new { originalShiftId = SelectedShift.Id, originalShiftDate = shiftDate });
        }
        private async Task<VolunteerProfile> PrepareModelAndGetCurrentVolunteer()
        {
            var user = await _userManager.GetUserAsync(User);
            await _context.Entry(user).Reference(p => p.VolunteerProfile).LoadAsync();

            await _context.Entry(user.VolunteerProfile).Collection(p => p.Shifts).LoadAsync();

            var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            var allShifts = await _context.Shifts.Include(x => x.PositionWorked).Include(y => y.Volunteer).Where(x => x.Hidden == false).ToListAsync();
            var assignedShiftDomainModels = new List<Shift>();
            var openShiftDomainModels = new List<Shift>();
            bool shiftShouldBeDisplayed;

            CurrentDateFilter filter = new CurrentDateFilter();

            // this foreach iterates through all the shifts and determines whether or not they should be displayed
            // and what color they should be displayed with (open vs assigned)
            foreach (var s in allShifts)
            {
                // CheckIfShiftDateIsAfterToday will handle recurring shifts in a special way:
                // it will check through all the shifts in it's recurrence set, if it finds one of the 
                // shifts to be scheduled past todays date, it will exclude all the shifts from that set
                // which are scheduled before todays date and display the rest
                shiftShouldBeDisplayed = filter.CheckIfShiftDateIsAfterToday(s);

                if (shiftShouldBeDisplayed)
                {
                    bool shiftIsOpen = s.Volunteer == null;
                    if (shiftIsOpen)
                    {
                        openShiftDomainModels.Add(s);
                    }
                    else
                    {
                        bool shiftIsAssignedToCurrentVolunteer = s.Volunteer.Id == user.VolunteerProfile.Id;
                        if (shiftIsAssignedToCurrentVolunteer)
                        {
                            assignedShiftDomainModels.Add(s);
                        }
                    }
                }
            }

            ShiftMapper mapper = new ShiftMapper(_mapper);

            AssignedShifts = mapper.MapShiftsToDtos(assignedShiftDomainModels);
            OpenShifts = mapper.MapShiftsToDtos(openShiftDomainModels);

            Positions = _context.Positions.ToList();
            LoggedInUser = user.VolunteerProfile.FirstName + " " + user.VolunteerProfile.LastName;

            return user.VolunteerProfile;
        }

        // this method requires the entire AppUser entity because it contains the user's email, and a 
        private async Task AssignShiftToVolunteer(Shift selectedShift, VolunteerProfile volunteer)
        {
            await _context.Entry(selectedShift).Reference(p => p.PositionWorked).LoadAsync();
            _context.Update(selectedShift);

            if (selectedShift is RecurringShift recShift)
            {
                await _context.Entry(recShift).Collection(p => p.ExcludedShifts).LoadAsync();
                Shift excludedShift = new Shift()
                {
                    StartDate = ClickedShiftDate,
                    StartTime = selectedShift.StartTime,
                    EndTime = selectedShift.EndTime,
                    Hidden = false,
                    PositionWorked = selectedShift.PositionWorked,
                    Volunteer = volunteer
                };
                excludedShift.CreateDescription();
                await _context.AddAsync(excludedShift);
                recShift.ExcludedShifts.Add(excludedShift);

                bool allShiftsInRecurringSetAreExcluded = recShift.ConstituentShifts.Count == recShift.ExcludedShifts.Count;

                if (allShiftsInRecurringSetAreExcluded)
                {
                    _context.Remove(recShift);
                }

                recShift.UpdateRecurrenceRule();

                // schedule email notification for shift
                //ReminderScheduler.ScheduleReminder(.Email, CurrentUser.VolunteerProfile, excludedShift, _context);
            }
            else
            {
                selectedShift.Volunteer = volunteer;
                selectedShift.CreateDescription();
                // schedule email notification for shift
                //    ReminderScheduler.ScheduleReminder(CurrentUser.Email, CurrentUser.VolunteerProfile, selectedShift, _context);
            }
            await _context.SaveChangesAsync();
        }
    }
}