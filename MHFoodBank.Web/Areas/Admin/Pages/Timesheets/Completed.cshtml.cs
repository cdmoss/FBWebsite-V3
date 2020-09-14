using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MHFoodBank.Common;
using MHFoodBank.Common.Dtos;
using MHFoodBank.Web.Areas.Admin.Pages.Shared;
using MHFoodBank.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace MHFoodBank.Web.Areas.Admin.Pages
{
    public class CompletedModel : AdminPageModel
    {
        [BindProperty]
        public string StatusMessage { get; set; }
        [BindProperty]
        public int DeleteClockedTimeId { get; set; }
        [BindProperty]
        public int ClockOutId { get; set; }
        [BindProperty]
        public string SearchedName { get; set; }
        [BindProperty]
        public Position SearchedPosition { get; set; } = new Position();
        [BindProperty]
        public int SearchedPositionId { get; set; }
        [BindProperty]
        public Position DefaultPosition { get; set; }
        [BindProperty]
        public List<Position> Positions { get; set; }
        [BindProperty]
        public DateTime ManualClockOutTime { get; set; }
        [BindProperty]
        public List<VolunteerMinimalDto> Volunteers { get; set; }
        [BindProperty]
        public DateTime SearchedStartDate { get; set; }
        [BindProperty]
        public TimeSpan SearchedStartTime { get; set; }
        [BindProperty]
        public DateTime SearchedEndDate { get; set; }
        [BindProperty]
        public TimeSpan SearchedEndTime { get; set; }
        [BindProperty]
        public DateTime EntryStartDate { get; set; }
        [BindProperty]
        public TimeSpan EntryStartTime { get; set; }
        [BindProperty]
        public DateTime EntryEndDate { get; set; }
        [BindProperty]
        public TimeSpan EntryEndTime { get; set; }
        [BindProperty]
        public List<ClockedTimeReadDto> ClockedTimes { get; set; }
        [BindProperty]
        public string SelectedPositionName { get; set; }
        [BindProperty]
        public string VolunteerNameForAdd { get; set; }
        [BindProperty]
        public string PositionNameForAdd { get; set; }
        [BindProperty]
        public string SelectedTab { get; set; }

        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public CompletedModel(IMapper mapper, FoodBankContext context, UserManager<AppUser> userManager, string currentPage = "Time Sheets") : base(context, currentPage)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task OnGet(string statusMessage)
        {
            StatusMessage = statusMessage;

            await PrepareModel();

            SearchedStartDate = DateTime.Now.Date;
            SearchedStartTime = DateTime.Now.Date.TimeOfDay;
            SearchedEndDate = DateTime.Now.Date.AddDays(1);
            SearchedEndTime = DateTime.Now.Date.TimeOfDay;
            EntryStartDate = DateTime.Now;
            EntryStartTime = DateTime.Now.Date.TimeOfDay;
            EntryEndDate = DateTime.Now.AddHours(5);
            EntryEndTime = DateTime.Now.AddHours(5).TimeOfDay;
        }

        public async Task<IActionResult> OnPostSaveChanges(int id)
        {
            var clockedTime = await _context.ClockedTime.FirstOrDefaultAsync(ct => ct.Id == id);
            _context.Update(clockedTime);

            string volunteerIdStr = Request.Form["entry-volunteer-" + id][0].Substring(0,1);
            int volunteerId = 0;
            if (int.TryParse(volunteerIdStr, out int volIdParsed))
            {
                volunteerId = volIdParsed;
            }
            else
            {
                // return error
            }
            string positionName = Request.Form["entry-position-" + id][0];
            if (!Positions.Any(p => p.Name == positionName))
            {
                // return error
            }
            var startDate = Convert.ToDateTime(Request.Form["entry-startdate-" + id]);
            var startTime = Convert.ToDateTime(Request.Form["entry-starttime-" + id]);

            var endDate = Convert.ToDateTime(Request.Form["entry-enddate-" + id]);
            var endTime = Convert.ToDateTime(Request.Form["entry-endtime-" + id]);

            clockedTime.Volunteer = await _context.VolunteerProfiles.FirstOrDefaultAsync(v => v.Id == volunteerId);
            clockedTime.Position = await _context.Positions.FirstOrDefaultAsync(v => v.Name == positionName);
            clockedTime.StartTime = startTime;
            clockedTime.EndTime = endTime;

            await _context.SaveChangesAsync();

            return RedirectToPage(new { statusMessage = $"Changes to the entry were successfully saved." }); ;
        }

        public async Task<IActionResult> OnPostClockOutVolunteer()
        {
            var clockedTime = await _context.ClockedTime.FirstOrDefaultAsync(ct => ct.Id == ClockOutId);
            _context.Update(clockedTime);

            clockedTime.EndTime = ManualClockOutTime;

            await _context.SaveChangesAsync();
            return RedirectToPage(new { statusMessage = $"Volunteer was successfully clocked out." }); ;
        }

        public async Task<IActionResult> OnPostAddEntry()
        {
            string volunteerIdStr = VolunteerNameForAdd.Split(' ')[0];
            int volunteerId = 0;
            if (int.TryParse(volunteerIdStr, out int volIdParsed))
            {
                volunteerId = volIdParsed;
            }
            else
            {
                // return error
            }
            if (!Positions.Any(p => p.Name == PositionNameForAdd))
            {
                // return error
            }

            var volunteer = await _context.VolunteerProfiles.FirstOrDefaultAsync(p => p.Id == volunteerId);
            var position = await _context.Positions.FirstOrDefaultAsync(p => p.Name == PositionNameForAdd);

            var start = EntryStartDate + EntryStartTime;
            var end = EntryEndDate + EntryEndTime;

            ClockedTime clock = new ClockedTime()
            {
                Position = position,
                Volunteer = volunteer,
                StartTime = start,
                EndTime = end
            };

            _context.ClockedTime.Add(clock);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { statusMessage = $"A new entry has been successfully added." });
        }

        public async Task<IActionResult> OnPostDeleteTime()
        {
            var clockedTime = await _context.ClockedTime.FirstOrDefaultAsync(c => c.Id == DeleteClockedTimeId);

            _context.ClockedTime.Remove(clockedTime);
            await _context.SaveChangesAsync();

            return RedirectToPage(new { statusMessage = "The selected entry has been successfully deleted." });
        }

        public async Task OnPostSearch()
        {
            int searchedPosId = SearchedPositionId;
            await PrepareModel();

            var startDate = SearchedStartDate + SearchedStartTime;
            var endDate = SearchedEndDate + SearchedEndTime;

            var searcher = new Searcher(_context);
            var searchedPosition = await _context.Positions.FirstOrDefaultAsync(p => p.Id == searchedPosId);
            ClockedTimes = searcher.FilterTimeSheetBySearch(ClockedTimes, SearchedName, searchedPosition, startDate, endDate);
        }

        private async Task PrepareModel()
        {
            var clockedTimeDtos = new List<ClockedTimeReadDto>();
            var volunteerDomainModels = await _context.VolunteerProfiles.Where(v => !v.IsStaff && v.ApprovalStatus != ApprovalStatus.Archived).ToListAsync();
            var clockedTimeDomainModels = await _context.ClockedTime
                .Include(p => p.Volunteer)
                .Include(p => p.Position)
                .ToListAsync();

            Positions = await _context.Positions.Where(p => !p.Deleted).ToListAsync();
            SearchedPositionId = Positions.FirstOrDefault(p => p.Name == "All").Id;
            Volunteers = _mapper.Map(volunteerDomainModels, Volunteers);
            clockedTimeDtos = _mapper.Map(clockedTimeDomainModels, clockedTimeDtos);

            ClockedTimes = clockedTimeDtos.Where(c => c.EndTime != null).ToList();
        }
    }
}
