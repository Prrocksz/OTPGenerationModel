﻿using System;
using OTPGeneration.Model;

namespace UnitTests.Service
{
	public class OtpGenerationServiceTest
	{
        [Test]
        public void GenerateOTP_ValidInput_ReturnsResponseObject()
        {
            // Arrange
            var otpService = new OtpService();
            var userId = "testuser";
            var dateTime = DateTime.UtcNow;

            // Act
            var result = otpService.GenerateOTP(userId, dateTime);

            // Assert
            Assert.IsNotNull(result);

            // Extract properties from the response object for further assertions
            dynamic response = result;
            Assert.IsNotNull(response.otp);
            Assert.IsNotNull(response.rem_time);
        }
    }
}

