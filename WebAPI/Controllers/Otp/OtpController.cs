using ENT.BL.Otp;
using ENT.Model.Common;
using ENT.Model.Otp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Otp
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtpController : ControllerBase
    {
        private readonly IOtp _otp;

        public OtpController(IOtp otp)
        {
            _otp = otp;
        }
       
      

        [HttpPost("OtpForAdmin")]
        public async Task<APIResponseModel> GenerateOtpForAdmin(string mobileNumber)
        {
            return await _otp.GenerateOtpForAdmin(mobileNumber);
        }

        [HttpGet("OtpForEndUser")]
        public async Task<APIResponseModel> GenerateOtpForEndUser(string mobileNumber)
        {
            return await _otp.GenerateOtpForEndUser(mobileNumber);
        }

        [HttpPost("OtpForServiceProvider")]
        public async Task<APIResponseModel> GenerateOtpForServiceProvider(string mobileNumber)
        {
            return await _otp.GenerateOtpForServiceProvider(mobileNumber);
        }

        [HttpGet("Verify")]
        public async Task<APIResponseModel> Verify(int Otp, string mobileNumber)
        {
            return await _otp.Verify( Otp,  mobileNumber);
        }

    }
}
