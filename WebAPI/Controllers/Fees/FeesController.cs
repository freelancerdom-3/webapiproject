using ENT.BL.Fees;
using ENT.Model.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Fees
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeesController : ControllerBase
    {
        private readonly IFees _fees;
        public FeesController (IFees fees)
        {
            _fees = fees;
        }
        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _fees.GetAll();
        }
    }
}
