using System;
using OtpNet;

namespace OTPGeneration.Model
{
	public class OtpService :IOtpService
	{
        public string? UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string? Token { get; set; }

        public object GenerateOTP(string userId, DateTime dateTime)
        {
            var secretKey = KeyGeneration.GenerateRandomKey(20);
            var totp = new Totp(secretKey, step: 30);
            int timeRemaining = totp.RemainingSeconds();
            var token = totp.ComputeTotp(dateTime);
            var response = new
            {
                otp = token,
                rem_time = timeRemaining
            };
            return response;
        }
    }
}

