﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MHFoodBank.Common
{ 
    public enum ApprovalStatus
    {
        Approved,
        Pending,
        Declined,
        Archived
    }

    public enum UserRole
    {
        Admin,
        Staff,
        Volunteer
    }
}
