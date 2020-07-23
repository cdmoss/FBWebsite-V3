﻿using System;
using System.Collections.Generic;
using System.Text;
using MHFoodBank.Common;
using MHFoodBank.Common.Services;

namespace MHFoodBank.Common.Dtos
{
    public class ShiftReadEditDto
    {
        public int Id { get; set; }
        [DateLessThan("EndDate")]
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Position PositionWorked { get; set; }
        public VolunteerMinimalDto Volunteer { get; set; }
        public int ParentRecurringShiftId { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public string Weekdays { get; set; }
        public string RecurrenceRule { get; set; }
        public bool Hidden { get; set; }
    }
}
