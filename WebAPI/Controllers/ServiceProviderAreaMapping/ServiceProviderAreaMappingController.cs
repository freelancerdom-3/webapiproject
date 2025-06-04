using ENT.BL.ServiceProviderAreaMapping;
using ENT.Model.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ENT.Model.ServiceProviderAreaMapping;
using ENT.Model.ServiceAreaMapping;

namespace WebAPI.Controllers.ServiceProviderAreaMapping
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceProviderAreaMappingController : ControllerBase
    {
        private readonly IServiceProviderAreMapping _serviceProviderAreaMapping;
        public ServiceProviderAreaMappingController(IServiceProviderAreMapping serviceproviderAreaMapping)
        {
            _serviceProviderAreaMapping = serviceproviderAreaMapping;
        }

        [HttpGet("GetAll")]
        public async Task<APIResponseModel> GetAll()
        {
            return await _serviceProviderAreaMapping.GetAll();
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(ServiceProviderAreaMappingModel objServiceproviderAreaMapping)
        {
            return await _serviceProviderAreaMapping.Add(objServiceproviderAreaMapping);
        }
        [HttpDelete]
        public async Task<APIResponseModel> Delete(int MappingId)
        {
            return await _serviceProviderAreaMapping.Delete(MappingId);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int MappingId)
        {
            return await _serviceProviderAreaMapping.GetById(MappingId);
        }

        [HttpPut]
        public async Task<APIResponseModel> Update(ServiceProviderAreaMappingModel objServiceproviderAreaMapping)
        {
            return await _serviceProviderAreaMapping.Update(objServiceproviderAreaMapping);
        }
    }
}
