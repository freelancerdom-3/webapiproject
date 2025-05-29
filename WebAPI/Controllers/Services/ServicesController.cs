using ENT.BL.Services;
using ENT.Model.Category;
using ENT.Model.Common;
using ENT.Model.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : Controller
    {
        private readonly IServices _Services;
        public ServicesController(IServices Services)
        {
            _Services = Services;
        }
        [HttpPost]
        public async Task<APIResponseModel> Add(ServicesModel objServicesModel)
        {
            return await _Services.Add(objServicesModel);
        }
        [HttpPut]
        public async Task<APIResponseModel> Update(ServicesModel objServicesModel)
        {
            return await _Services.Update(objServicesModel);
        }
        [HttpDelete]
        public async Task<APIResponseModel> Delete(int ServiceId)
        {
            return await _Services.Delete(ServiceId);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int ServiceId)
        {
            return await _Services.GetById(ServiceId);
        }
        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _Services.GetAll();
        }


    }
}
