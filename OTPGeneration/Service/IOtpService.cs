using System;
namespace OTPGeneration.Model
{
	public interface IOtpService
    {
        public OTPModel GenerateOTP(string userId, DateTime dateTime);
    }
}

