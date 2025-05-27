using ENT.BL.Otp;
using ENT.BL.User;
using ENT.Model.Common;
using ENT.Model.Otp;
using ENT.Model.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Otp
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtpController : ControllerBase
    {
        private readonly IOtp _Otp;

        public OtpController(IOtp otp)
        {
            _Otp = otp;
        }
        [HttpPost]
        public async Task<APIResponseModel> Add(OtpModel objOtpModel)
        {
            return await _Otp.Add(objOtpModel);
        }
        [HttpPut]
        public async Task<APIResponseModel> Update(OtpModel objOtpModel)
        {
            return await _Otp.Update(objOtpModel);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int OtpId)
        {
            return await _Otp.GetById(OtpId);
        }
    }
}
