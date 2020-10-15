﻿using System;
using static MHFoodBank.Common.ShiftRequestAlert;

namespace MHFoodBank.Common.Dtos
{
    public class AdminAlertListDto
    {
        public int Id { get; set; }
        public VolunteerMinimalDto Volunteer { get; set; }
        public string UserFullName { get; set; }
        public DateTime Date { get; set; }
        public bool Read { get; set; }
        public string AlertType { get; set; }
        public string AddressedBy { get; set; }
    }

    public class VolunteerShiftRequestListDto
    {
        public int Id { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime OriginalShiftDate { get; set; }
        public DateTime? RequestedShiftDate { get; set; }
        public RequestStatus Status { get; set; }
    }

    public class ShiftRequestReadDto
    {
        public int Id { get; set; }
        public VolunteerMinimalDto Volunteer { get; set; }
        public ShiftReadEditDto OriginalShift { get; set; }
        public ShiftReadEditDto RequestedShift { get; set; }
        public RequestStatus Status { get; set; }
        public string Reason { get; set; }
    }

    public class ShiftRequestCreateDto
    {
        public int OriginalShiftId { get; set; }
        public int RequestedShiftId { get; set; }
        public string Reason { get; set; }

    }
}
