using System;
using OtpNet;

namespace OTPGeneration.Model
{
	public class OtpService :IOtpService
	{
        private readonly OTPModel _otpModel;
        public OtpService()
        {
            _otpModel = new OTPModel();
        }
        public OTPModel GenerateOTP(string userId, DateTime dateTime)
        {
            var secretKey = KeyGeneration.GenerateRandomKey(20);
            var totp = new Totp(secretKey, step: 30);
            int timeRemaining = totp.RemainingSeconds();
            var token = totp.ComputeTotp(dateTime);
            _otpModel.remTime = timeRemaining.ToString();
            _otpModel.Token = token;
            _otpModel.UserId = userId;
            return _otpModel;
        }
    }
}

