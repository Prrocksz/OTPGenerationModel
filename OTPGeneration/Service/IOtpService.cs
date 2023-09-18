using System;
namespace OTPGeneration.Model
{
	public interface IOtpService
    {
        /// <summary>
        /// Method used to generate an OTP
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public OTPModel GenerateOTP(string userId, DateTime dateTime);
    }
}

