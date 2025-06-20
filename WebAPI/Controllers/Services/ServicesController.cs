using ENT.BL.Services;
using ENT.Model.Category;
using ENT.Model.Common;
using ENT.Model.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Services
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly IServices _services;
        public ServicesController(IServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(ServicesModel objServicesModel)
        {
            return await _services.Add(objServicesModel);
        }

        [HttpPut]
        public async Task<APIResponseModel> Update(ServicesModel objServicesModel)
        {
            return await _services.Update(objServicesModel);
        }

        [HttpDelete]
        public async Task<APIResponseModel> Delete(int ServiceId)
        {
            return await _services.Delete(ServiceId);
        }

        [HttpGet("GetByName")]
        [AllowAnonymous]
        public async Task<APIResponseModel> GetByName(string ServiceName, string? regionType, int? regionId)
        {
            return await _services.GetByName(ServiceName, regionType, regionId);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<APIResponseModel> GetAll()
        {
            return await _services.GetAll();
        }

        [HttpGet("GetBySubCategoryId")]
        public async Task<APIResponseModel> GetBySubCategoryId(int id, string type)
        {
            return await _services.GetBySubCategoryId(id, type);
        }
    }
}
