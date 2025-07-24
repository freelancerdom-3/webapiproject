using ENT.BL.Order;
using ENT.Model.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Order
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _order;
        public OrderController(IOrder order)
        {
            _order = order;
        }

        [HttpGet("GetByConfirmedOrderId")]
        public async Task<APIResponseModel> GetByConfirmedOrderId(int orderId)
        {
            return await _order.GetConfirmedOrder(orderId);
        }
    }
}
