using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.Otp;
using Microsoft.EntityFrameworkCore;


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
                response.Message= ex.Message;
            }
            return response;
        }
        public async Task<APIResponseModel> GetById(int OtpId)
        {
            APIResponseModel response = new APIResponseModel();
            try 
            {
                using (var context = _context)
                {
                    response.Data =  _context.TblOtp.Where(x => x.OTPId == OtpId).ToList();
                   
                }
              Console.WriteLine(response.Data);
                response.statusCode = 200;
                return response;
            }
             catch(Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
            }        
            return response;
        }
        public async Task<APIResponseModel> Verify(int Otp, string mobileNumber)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var context = _context)
                {
                    var record =  await context.TblOtp.Where(x => x.MobileNumber == mobileNumber && x.OTP == Otp)
                    .FirstOrDefaultAsync();
                    
                    if (record == null)
                    {
                        response.statusCode = 204;
                        response.Message = "Invalid OTP or Mobile Number.";
                        return response;
                    }
                    else 
                    {
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
