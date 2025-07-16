using ENT.BL.OrderID;
using ENT.Model.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.OrderID
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderIDController : ControllerBase
    {
        private readonly IOrderID _orderID;
        public OrderIDController(IOrderID orderID)
        {
            _orderID = orderID;
        }

        [HttpGet]
        public async Task<APIResponseModel> GenerateOrderID()
        {
            return await _orderID.GenerateOrderID();
        }
    }
}
