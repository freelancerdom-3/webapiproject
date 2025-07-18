using ENT.BL.ServiceProviderSubCategoryMapping;
using ENT.Model.Common;
using ENT.Model.CustomModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ServiceProviderSubCategoryMapping
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
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
        [HttpPost]
        [AllowAnonymous]
        public async Task<APIResponseModel> GetBySkill(SkillViewModel objSkill)
        {
            return await _ServiceProviderSubCategoryMapping.GetBySkill(objSkill);
        }

        [HttpGet("HasSkills")]
        public async Task<IActionResult> HasSkills(int userId)
        {
            var response = await _ServiceProviderSubCategoryMapping.HasSkills(userId);
            return Ok(response);
        }

     
    }
}
