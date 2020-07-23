﻿using MHFoodBank.Common.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MHFoodBank.Common.Dtos
{
    public class WorkExperienceDto
    {
        public int Id { get; set; }
        [Display(Name = "Employer Name")]
        public string EmployerName { get; set; }
        [Display(Name = "Employer Address")]
        public string EmployerAddress { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        [Display(Name = "Employer Phone")]
        [RegularExpression(@"\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\D*", ErrorMessage = "Please enter a valid phone number.")]
        public string EmployerPhone { get; set; }
        [Display(Name = "Contact Name")]
        public string ContactPerson { get; set; }
        [Display(Name = "Position Worked")]
        public string PositionWorked { get; set; }
        public bool CurrentJob { get; set; }
    }
}
