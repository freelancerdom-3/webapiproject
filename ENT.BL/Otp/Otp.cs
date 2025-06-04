using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.Otp;
using Microsoft.EntityFrameworkCore;
using System;


namespace ENT.BL.Otp
{
    public class Otp : IOtp
    {
        private readonly MyDBContext _context;
        public Otp(MyDBContext context)
        {
            _context = context;
        }

        public object OtpRecord { get; private set; }

        public async Task<APIResponseModel> Add( string mobileNumber)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {

                //add logic to create random 6 digit code -- 123456
                OtpModel otpObject = new OtpModel();
                Random random = new Random();
                int otpCode = random.Next(100000, 999999);
                otpObject.OTP = otpCode;
                otpObject.MobileNumber = mobileNumber;
                // add expiration time = current time + 5 mins
                otpObject.ExpiryTime = DateTime.Now.AddMinutes(5);
                otpObject.IsUsed = false;

                using (var connection = _context)
                {
                    await connection.TblOtp.AddAsync(otpObject);
                    await connection.SaveChangesAsync();
                }
                response.Data = otpObject;
                response.Message = "OTP Generated successfully";
                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
            }
            return response;
        } //10:30 -- 10:35

        public async Task<APIResponseModel> Verify(int Otp, string mobileNumber) //123456, 9033342003
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                   

                    //mobile number does not exists
                    OtpModel otpObject = await connection.TblOtp.Where(x => x.MobileNumber == mobileNumber).OrderByDescending(x => x.OTPId).LastAsync();

                    if(otpObject != null)
                    {
                        if(otpObject.OTP == Otp && otpObject.ExpiryTime > DateTime.Now)
                        {
                            if(otpObject.OTP == Otp && otpObject.IsUsed == false)
                            {
                                //write update logic
                                otpObject.IsUsed = true;
                                await connection.SaveChangesAsync();
                                response.Message = "OTP verified";
                            }
                            else
                            {
                                response.Message = "OTP is used";
                            }
                        }
                        else
                        {
                            response.Message = "OTP expired";
                        }
                    }
                    else
                    {
                        response.Message = "Mobile number or OTP invalid";
                    }
                }      
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
            }
            return response;
        }
    }   
}
