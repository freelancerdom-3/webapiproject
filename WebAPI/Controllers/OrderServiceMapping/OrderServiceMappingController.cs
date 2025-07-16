using ENT.BL.OrderServiceMapping;
using ENT.Model.Common;
using ENT.Model.CustomModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.OrderServiceMapping
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderServiceMappingController : ControllerBase
    {
        private readonly IOrderServiceMapping _orderServiceMappingService;
        public OrderServiceMappingController(IOrderServiceMapping orderServiceMapping)
        {
            _orderServiceMappingService = orderServiceMapping;
        }
        [HttpPost("AddServicesInOrder")]
        public async Task<APIResponseModel> AddServicesInOrder([FromBody]PlaceServiceOrderViewModel objPlaceServiceOrderVeiwModel)
        {
            return await _orderServiceMappingService.AddServicesInOrder(objPlaceServiceOrderVeiwModel);
        }
    }
}
