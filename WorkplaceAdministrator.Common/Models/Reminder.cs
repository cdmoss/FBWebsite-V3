﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceAdministrator.Web.Data.Models
{
    // this enitity only exists to link the main db to the hangfire db
    public class Reminder
    {
        public int Id { get; set; }
        public int ShiftId { get; set; }
        public DateTime ShiftDate { get; set; }
        public string HangfireJobId { get; set; }
    }
}
