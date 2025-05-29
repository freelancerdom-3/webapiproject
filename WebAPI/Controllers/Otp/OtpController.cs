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
       
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int OtpId)
        {
            return await _otp.GetById(OtpId);
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(OtpModel objOtpModel)
        {
            return await _otp.Add(objOtpModel);
        }
        [HttpGet("Verify")]
        public async Task<APIResponseModel> Verify(int Otp, string mobileNumber)
        {
            return await _otp.Verify( Otp,  mobileNumber);
        }

    }
}
