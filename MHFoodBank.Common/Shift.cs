﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHFoodBank.Common
{
    [Serializable]
    // the shift class encompasses three kinds of shifts:
    // - a regular shift
    // - a recurring shift
    // - a shift that was changed from a recurring set
    public class Shift
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? PositionId { get; set; }
        public Position Position { get; set; }
        public int? VolunteerProfileId { get; set; }
        public VolunteerProfile Volunteer { get; set; }
        public string Description { get; set; }
        public bool IsRecurrence { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }
        public int? RecurrenceID { get; set; }
        public bool IsBlock { get; set; }
        public string Resource { get; set; }

        public void CreateTitle()
        {
            if (Volunteer != null)
            {
                Subject = Volunteer.FirstName + " " + Volunteer.LastName + " - " + Position.Name;
            }
            else
            {
                Subject = "Open" + " - " + Position.Name;
            }
        }
    }
}
