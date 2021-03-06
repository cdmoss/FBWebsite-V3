﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MHFoodBank.Common
{
    [Serializable]
    public class Reference
    {
        public int Id { get; set; }
        public VolunteerProfile Volunteer { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public string Occupation { get; set; }
    }
}
