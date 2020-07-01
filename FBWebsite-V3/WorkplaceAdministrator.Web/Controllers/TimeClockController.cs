﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkplaceAdministrator.Common.Dtos;
using WorkplaceAdministrator.Common.Models;
using WorkplaceAdministrator.Web.Repositories;

namespace WorkplaceAdministrator.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TimeClockController : ControllerBase
    {
        private readonly IClockedTimeRepo _clockedTimeRepo;

        public TimeClockController(IClockedTimeRepo clockedTimeRepo)
        {
            _clockedTimeRepo = clockedTimeRepo;
        }

        [HttpPost("punch-clock")]
        [Authorize(Roles = "Admin, Staff, Volunteer")]
        public async Task<IActionResult> PunchClockAsync(ClockedTimeDto dto)
        {
            var clockInResult = await _clockedTimeRepo.PunchClock(dto);

            return Ok(clockInResult);
        }
    }
}
