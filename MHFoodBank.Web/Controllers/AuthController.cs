﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using MHFoodBank.Common;
//using MHFoodBank.Common.Dtos;

//namespace MHFoodBank.Api.Controllers
//{
//    [Authorize]
//    [Route("[controller]")]
//    [ApiController]
//    public class AuthController : ControllerBase
//    {
//        [AllowAnonymous]
//        [HttpPost("login")]
//        public async Task<IActionResult> LoginAsync(LoginDto loginDto)
//        {
//            AuthResponse response = await _authService.LoginAsync(loginDto);

//            return Ok(response);

//        }

//        [AllowAnonymous]
//        [HttpPost("register")]
//        public async Task<IActionResult> RegisterAsync(TestRegisterDto registerDto)
//        {
//            AuthResponse response = await _authService.RegisterAsync(registerDto);
//            return Ok(response);
//        }
//    }
//}
