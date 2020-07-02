﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MHFoodBank.Web.Dtos
{
    public class AvailabilityDto
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string AvailableDay { get; set; }
    }
}
