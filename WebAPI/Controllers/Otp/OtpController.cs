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
       
      

        [HttpPost]
        public async Task<APIResponseModel> Add(string mobileNumber)
        {
            return await _otp.Add(mobileNumber);
        }

        [HttpGet("Verify")]
        public async Task<APIResponseModel> Verify(int Otp, string mobileNumber)
        {
            return await _otp.Verify( Otp,  mobileNumber);
        }

    }
}
