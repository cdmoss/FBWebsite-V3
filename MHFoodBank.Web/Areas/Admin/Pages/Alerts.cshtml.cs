﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MHFoodBank.Web.Areas.Admin.Pages.Shared;
using MHFoodBank.Web.Data;
using MHFoodBank.Web.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MHFoodBank.Web.Areas.Admin.Pages
{
    [BindProperties]
    [Authorize(Roles = "Staff, Admin")]
    public class AlertsModel : AdminPageModel
    {
        public List<ShiftRequestAlert> PendingRequests { get; set; }
        public List<ShiftRequestAlert> ArchivedRequests { get; set; }
        public List<ApplicationAlert> ApplicationAlerts { get; set; }
        public string SearchedName { get; set; }
        public string StatusMessage { get; set; }

        public AlertsModel(FoodBankContext context, string currentPage = "Alerts") : base(context, currentPage)
        {

        }

        public async Task OnGet(string statusMessage = null)
        {
            StatusMessage = statusMessage;
            await PrepareModel();
        }

        public async Task<IActionResult> OnPostViewApplicant(int id)
        {
            Alert selectedAlert = await _context.Alerts.FirstOrDefaultAsync(a => a.Id == id);
            //TODO: This is throwing a null error
            await _context.Entry(selectedAlert).Reference(a => a.Volunteer).LoadAsync();
            _context.Alerts.Update(selectedAlert);
            selectedAlert.HasBeenRead = true;
            await _context.SaveChangesAsync();
            return RedirectToPage("VolunteerDetails", new { id = selectedAlert.Volunteer.Id });
        }

        public async Task<IActionResult> OnPostViewRequest(int id)
        {
            Alert selectedAlert = await _context.Alerts.FirstOrDefaultAsync(a => a.Id == id);
            await _context.Entry(selectedAlert).Reference(a => a.Volunteer).LoadAsync();
            _context.Alerts.Update(selectedAlert);
            selectedAlert.HasBeenRead = true;
            await _context.SaveChangesAsync();
            return RedirectToPage("ResolveShiftRequest", new { id = selectedAlert.Id });
        }

        public async Task<IActionResult> OnPostDeleteAlert(int id)
        {
            Alert selectedAlert = await _context.Alerts.FirstOrDefaultAsync(a => a.Id == id);

            if (selectedAlert is ShiftRequestAlert)
            {
                ShiftRequestAlert shiftAlert = (ShiftRequestAlert)selectedAlert;

                await _context.Entry(shiftAlert).Reference(p => p.OriginalShift).LoadAsync();
                await _context.Entry(shiftAlert).Reference(p => p.RequestedShift).LoadAsync();

                if (shiftAlert.DismissedByVolunteer)
                {
                    _context.Alerts.Remove(shiftAlert);
                    _context.Remove(shiftAlert.OriginalShift);
                    _context.Remove(shiftAlert.RequestedShift);
                }
                else
                {
                    _context.Alerts.Update(selectedAlert);
                    ((ShiftRequestAlert)selectedAlert).DismissedByAdmin = true;
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                _context.Alerts.Remove(selectedAlert);
            }
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

        private async Task PrepareModel()
        {
            List<ShiftRequestAlert> shiftRequests = await _context.ShiftAlerts
                .Include(p => p.Volunteer)
                .Where(a => a.DismissedByAdmin == false)
                .ToListAsync();

            PendingRequests = shiftRequests.Where(sr => sr.Status == ShiftRequestAlert.RequestStatus.Pending).ToList();
            ArchivedRequests = shiftRequests.Where(sr => sr.Status != ShiftRequestAlert.RequestStatus.Pending).ToList();

            ApplicationAlerts = await _context.ApplicationAlerts
                .Include(p => p.Volunteer)
                .ToListAsync();

            PendingRequests = PendingRequests.OrderByDescending(a => a.Date).ToList();
            ArchivedRequests = ArchivedRequests.OrderByDescending(a => a.Date).ToList();
            ApplicationAlerts = ApplicationAlerts.OrderByDescending(a => a.Date).ToList();
        }

        //public async Task OnPostSearch()
        //{
        //    if (SearchedName != null)
        //    {
        //        Alerts = await _context.Alerts
        //            .Include(p => p.User)
        //            .ThenInclude(u => u.VolunteerProfile)
        //            .ToListAsync();
        //        Alerts = Alerts.Where(a => a.User.VolunteerProfile.FullNameWithID.Contains(SearchedName)).ToList();
        //    }
        //    else
        //    {
        //        Alerts = await _context.Alerts
        //            .Include(p => p.User)
        //            .ThenInclude(u => u.VolunteerProfile)
        //            .ToListAsync();
        //    }
        //
        //    Alerts = Alerts.OrderByDescending(a => a.Date).ToList();
        //}
    }
}