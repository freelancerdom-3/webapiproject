using System.Runtime.CompilerServices;
using ENT.Model.Common;
using ENT.Model.ServiceCartMapping;
using ENT.BL.ServiceCartMapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;


namespace WebAPI.Controllers.ServiceCartMapping
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServiceCartMappingController : ControllerBase
    {
        private readonly IServiceCartMapping _ServiceCartMapping;

        public ServiceCartMappingController(IServiceCartMapping ServiceCartMapping)
        {
            _ServiceCartMapping = ServiceCartMapping;
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(ServiceCartMappingModel objServiceCartMappingModel)
        {
            return await _ServiceCartMapping.Add(objServiceCartMappingModel);
        }

        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _ServiceCartMapping.GetAll();
        }

        [HttpGet("GetByCartId")]
        public async Task<APIResponseModel> GetByCartId(int ServiceCartMappingId)
        {
            return await _ServiceCartMapping.GetByCartId(ServiceCartMappingId);
        }

        [HttpPut]
        public async Task<APIResponseModel> Update(ServiceCartMappingModel objServiceCartMappingModel)
        {
            return await _ServiceCartMapping.Update(objServiceCartMappingModel);
        }


        [HttpDelete]
        public async Task<APIResponseModel> Delete(int ServiceCartMappingId)
        {
            return await _ServiceCartMapping.Delete(ServiceCartMappingId);
        }
    }
}
