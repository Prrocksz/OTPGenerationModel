using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OTPGeneration.Model;


namespace OTPGeneration.Controllers
{
    [Route("api/")]
    public class OtpGenerationController : Controller
    {
        private readonly IOtpService _otpService;

        public OtpGenerationController (OtpService otpService)
        {
            _otpService = otpService;
        }

        [HttpGet]
        [Route("GenerateOTP")]
        public IActionResult Get(string userName)
        {
            var otp = _otpService.GenerateOTP(userName, DateTime.Now);
            return Ok(otp);
        }
    }
}

