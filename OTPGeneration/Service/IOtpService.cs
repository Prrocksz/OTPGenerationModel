using System;
namespace OTPGeneration.Model
{
	public interface IOtpService
    {
        public object GenerateOTP(string userId, DateTime dateTime);
    }
}

