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
        public async Task<APIResponseModel> Add(OtpModel objOtpModel)
        {
            return await _otp.Add(objOtpModel);
        }
        [HttpPut]
        public async Task<APIResponseModel> Update(OtpModel objOtpModel)
        {
            return await _otp.Update(objOtpModel);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int OtpId)
        {
            return await _otp.GetById(OtpId);
        }
    }
}
