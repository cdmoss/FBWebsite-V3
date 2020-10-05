﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Hangfire;
using MHFoodBank.Web.Areas.Volunteer.Pages.Shared;
using MHFoodBank.Web.Data;
using MHFoodBank.Common;
using MHFoodBank.Common.Dtos;
using MHFoodBank.Web.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MHFoodBank.Common.Services;

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
        public ShiftReadEditDto SelectedShift { get; set; } = new ShiftReadEditDto();
        [BindProperty]
        public ApprovalStatus Approved { get; set; }

        public VolunteerCalendarModel(FoodBankContext context, UserManager<AppUser> userManager, IMapper mapper, string currentPage = "Schedule") : base(userManager, context, currentPage)
        {
            _mapper = mapper;
        }

        public async Task OnGet(string statusMessage = null)
        {
            StatusMessage = statusMessage;
            await GetVolunteer();
        }

        public async Task<JsonResult> OnPostGetMyShifts()
        {
            var user = await _userManager.GetUserAsync(User);
            await _context.Entry(user).Reference(u => u.VolunteerProfile).LoadAsync();
            await _context.Entry(user.VolunteerProfile).Collection(v => v.Shifts).LoadAsync();
            var userShifts = user.VolunteerProfile.Shifts;
            bool shiftShouldBeDisplayed;
            CurrentDateFilter filter = new CurrentDateFilter();
            var displayedShifts = new List<Shift>();
            // this foreach iterates through all the shifts and determines whether or not they should be displayed
            // and what color they should be displayed with (open vs assigned)
            foreach (var s in userShifts)
            {
                // CheckIfShiftDateIsAfterToday will handle recurring shifts in a special way:
                // it will check through all the shifts in it's recurrence set, if it finds one of the 
                // shifts to be scheduled past todays date, it will exclude all the shifts from that set
                // which are scheduled before todays date and display the rest
                shiftShouldBeDisplayed = filter.CheckIfShiftDateIsAfterToday(s);

                if (shiftShouldBeDisplayed)
                {
                    displayedShifts.Add(s);
                }
            }

            return new JsonResult(_mapper.Map<List<ShiftReadEditDto>>(displayedShifts));
        }

        public async Task<JsonResult> OnPostGetOpenShifts()
        {
            var openShifts = await _context.Shifts.Where(s => s.VolunteerProfileId == null).ToListAsync();
            bool shiftShouldBeDisplayed;
            CurrentDateFilter filter = new CurrentDateFilter();
            var displayedShifts = new List<Shift>();
            // this foreach iterates through all the shifts and determines whether or not they should be displayed
            // and what color they should be displayed with (open vs assigned)
            foreach (var s in openShifts)
            {
                // CheckIfShiftDateIsAfterToday will handle recurring shifts in a special way:
                // it will check through all the shifts in it's recurrence set, if it finds one of the 
                // shifts to be scheduled past todays date, it will exclude all the shifts from that set
                // which are scheduled before todays date and display the rest
                shiftShouldBeDisplayed = filter.CheckIfShiftDateIsAfterToday(s);

                if (shiftShouldBeDisplayed)
                {
                    displayedShifts.Add(s);
                }
            }

            return new JsonResult(_mapper.Map<List<ShiftReadEditDto>>(displayedShifts));
        }

        private async Task<VolunteerProfile> GetVolunteer()
        {
            var user = await _userManager.GetUserAsync(User);
            await _context.Entry(user).Reference(p => p.VolunteerProfile).LoadAsync();

            Approved = user.VolunteerProfile.ApprovalStatus;


            LoggedInUser = user.VolunteerProfile.FirstName + " " + user.VolunteerProfile.LastName;

            return user.VolunteerProfile;
        }
    }
}