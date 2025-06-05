using ENT.BL.ServiceProviderSubCategoryMapping;
using ENT.Model.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ServiceProviderSubCategoryMapping
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServiceProviderSubCategoryMappingController : ControllerBase
    {
        private readonly IServiceProviderSubCategoryMapping _ServiceProviderSubCategoryMapping;
        public ServiceProviderSubCategoryMappingController(IServiceProviderSubCategoryMapping ServiceProviderSubCategoryMapping)
        {
            _ServiceProviderSubCategoryMapping = ServiceProviderSubCategoryMapping;
        }
        [HttpGet("GetByArea")]
        public async Task<APIResponseModel> GetByArea(string AreaName)
        {
            return await _ServiceProviderSubCategoryMapping.GetByArea(AreaName);
        }
        [HttpGet("GetBySubCategoryName")]
        public async Task<APIResponseModel> GetBySubCategoryName(string SubCategoryName)
        {
            return await _ServiceProviderSubCategoryMapping.GetBySubCategoryName(SubCategoryName);
        }
    }
}
