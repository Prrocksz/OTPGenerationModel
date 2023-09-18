using Microsoft.AspNetCore.Mvc;
using OTPGeneration.Model;


namespace OTPGeneration.Controllers
{
    [Route("api/")]
    public class OtpGenerationController : Controller
    {
        private readonly IOtpService _otpService;

        public OtpGenerationController (IOtpService otpService)
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

