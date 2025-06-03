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

        public async Task<APIResponseModel> Add(OtpModel objOtp)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {

              

                using (var connection = _context)
                {
                    //add logic to create random 6 digit code -- 123456

                    Random random = new Random();
                    int otpCode = random.Next(100000, 999999);
                    objOtp.OTP = otpCode;
                    // add expiration time = current time + 5 mins
                    objOtp.ExpiryTime = DateTime.UtcNow.AddMinutes(5);
                    objOtp.IsUsed = false;
                    //create final objOtp model and then submit to db

                    await connection.TblOtp.AddAsync(objOtp);
                    await connection.SaveChangesAsync();
                }
                response.Data = true;
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
                using (var context = _context)
                {
                    var record =  await context.TblOtp.Where(x => x.MobileNumber == mobileNumber && x.OTP == Otp && x.IsUsed == false && x.ExpiryTime > DateTime.Now)
                    .FirstOrDefaultAsync(); //isused=false && (expirationtime 10:35 less than expirationime)
                    
                    if (record == null)
                    {
                        response.statusCode = 204;
                        response.Message = "Invalid OTP or Mobile Number.";
                        return response;
                    }
                    else 
                    {

                        // update same otp as isused=true;
                        record.IsUsed = true;
                        response.Data = record;
                        response.statusCode = 200;
                        response.Message = "OTP has already been used.";
                        return response;
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
