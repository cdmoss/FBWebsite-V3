﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MHFoodBank.Common;
using Microsoft.AspNetCore.Http;
using MHFoodBank.Common.Dtos;

namespace MHFoodBank.Web.Data
{
    public class Searcher
    {
        private readonly FoodBankContext _context;

        public Searcher(FoodBankContext context)
        {
            _context = context;
        }

        private bool CheckIfNameWasSearched(string name)
        {
            bool check = false;
            if (!String.IsNullOrWhiteSpace(name))
            {
                check = true;
                name = name.ToLower();
            }
            return check;
        }

        private bool CheckIfPositionWasSearched(Position position)
        {
            bool check = false;
            if (position != null)
            {
                if (position.Id != 4)
                {
                    check = true;
                }
            }
            return check;
        }

        public List<VolunteerProfile> FilterVolunteersBySearch(List<VolunteerProfile> volunteers, string name, Position searchedPosition)
        {
            bool positionWasSearched = CheckIfPositionWasSearched(searchedPosition);
            bool nameWasSearched = CheckIfNameWasSearched(name);

            if (positionWasSearched && nameWasSearched)
            {
                volunteers = volunteers.Where(v =>
                    v.FullNameWithID.ToLower().Contains(name.ToLower()) &&
                    v.Positions.Any(p => p.Position == searchedPosition)).ToList();
            }

            if (!positionWasSearched && nameWasSearched)
            {
                volunteers = volunteers.Where(v =>
                    v.FullNameWithID.ToLower().Contains(name.ToLower())).ToList();
            }

            if (positionWasSearched && !nameWasSearched)
            {
                volunteers = volunteers.Where(v =>
                    v.Positions.Any(p => p.Position == searchedPosition)).ToList();
            }

            return volunteers;
        }

        public List<ShiftReadEditDto> FilterShiftsBySearch(List<ShiftReadEditDto> shifts, string name, Position searchedPosition)
        {
            bool positionWasSearched = CheckIfPositionWasSearched(searchedPosition);
            bool nameWasSearched = CheckIfNameWasSearched(name);

            if (positionWasSearched && nameWasSearched)
            {
                // strip out any open shifts first to prevent nullexceptions
                shifts = shifts.Where(s => s.Volunteer != null).ToList();

                shifts = shifts.Where(s =>
                    s.Volunteer.FullNameWithID.ToLower().Contains(name.ToLower()) &&
                    s.PositionWorked == searchedPosition).ToList();
            }

            if (!positionWasSearched && nameWasSearched)
            {
                // strip out any open shifts first to prevent nullexceptions
                shifts = shifts.Where(s => s.Volunteer != null).ToList();

                shifts = shifts.Where(s =>
                    s.Volunteer.FullNameWithID.ToLower().Contains(name.ToLower())).ToList();
            }

            if (positionWasSearched && !nameWasSearched)
            {
                shifts = shifts.Where(s =>
                    s.PositionWorked == searchedPosition).ToList();
            }

            return shifts;
        }

        public List<ClockedTimeReadDto> FilterTimeSheetBySearch(
            List<ClockedTimeReadDto> clockedTimes, 
            string name, 
            Position searchedPosition, 
            DateTime start,
            DateTime end)
        {
            bool positionWasSearched = CheckIfPositionWasSearched(searchedPosition);
            bool nameWasSearched = CheckIfNameWasSearched(name);

            clockedTimes = clockedTimes.Where(ct =>
                ct.StartTime >= start &&
                ct.EndTime <= end).ToList();

            if (positionWasSearched && nameWasSearched)
            {
                clockedTimes = clockedTimes.Where(s =>
                    s.Volunteer.FullNameWithID.ToLower().Contains(name.ToLower()) &&
                    s.Position.Id == searchedPosition.Id).ToList();
            }

            if (!positionWasSearched && nameWasSearched)
            {
                clockedTimes = clockedTimes.Where(s =>
                    s.Volunteer.FullNameWithID.ToLower().Contains(name.ToLower())).ToList();
            }

            if (positionWasSearched && !nameWasSearched)
            {
                clockedTimes = clockedTimes.Where(s =>
                    s.Position.Id == searchedPosition.Id).ToList();
            }

            return clockedTimes;
        }

        public List<ClockedTimeReadDto> FilterTimeSheetBySearch(
        List<ClockedTimeReadDto> clockedTimes,
        string name,
        Position searchedPosition)
        {
            bool positionWasSearched = CheckIfPositionWasSearched(searchedPosition);
            bool nameWasSearched = CheckIfNameWasSearched(name);

            if (positionWasSearched && nameWasSearched)
            {
                clockedTimes = clockedTimes.Where(s =>
                    s.Volunteer.FullNameWithID.ToLower().Contains(name.ToLower()) &&
                    s.Position.Id == searchedPosition.Id).ToList();
            }

            if (!positionWasSearched && nameWasSearched)
            {
                clockedTimes = clockedTimes.Where(s =>
                    s.Volunteer.FullNameWithID.ToLower().Contains(name.ToLower())).ToList();
            }

            if (positionWasSearched && !nameWasSearched)
            {
                clockedTimes = clockedTimes.Where(s =>
                    s.Position.Id == searchedPosition.Id).ToList();
            }

            return clockedTimes;
        }

        public Position GetSearchedPosition(HttpRequest request)
        {
            int searchedPositionId = -1;

            // records id of searched position if position was entered
            if (request.Form["searchedposition"] != "All")
            {
                searchedPositionId = Convert.ToInt32(request.Form["searchedposition"]);
            }
            Position position = _context.Positions.FirstOrDefault(p => p.Id == searchedPositionId);
            return position;
        }
    }
}
