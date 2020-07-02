﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using MHFoodBank.Api.Repositories;
//using MHFoodBank.Common;
//using MHFoodBank.Common.Dtos;

//namespace MHFoodBank.Api.Controllers
//{
//    [Route("[controller]")]
//    [ApiController]
//    public class ShiftsController : ControllerBase
//    {
//        private readonly IShiftRepo _shiftRepo;

//        public ShiftsController(IShiftRepo shiftRepo)
//        {
//            _shiftRepo = shiftRepo;
//        }

//        [HttpGet("all")]
//        [Authorize(Roles = "Admin, SuperAdmin, Employee")]
//        public IActionResult GetAllShiftsAsync()
//        {
//            var response = new OperationResponse<List<ShiftReadEditDto>>()
//            {
//                ResponseDto = _shiftRepo.GetAllShifts(),
//                Message = "Data retrieved successfully",
//                IsSuccess = true,
//            };

//            return Ok(response);
//        }
//    }
//}
