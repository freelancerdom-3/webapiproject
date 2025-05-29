using System.Runtime.CompilerServices;
using ENT.Model.Common;
using ENT.Model.UserCartMapping;
using ENT.BL.UserCartMapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace WebAPI.Controllers.UserCartMapping
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCartMappingController : ControllerBase
    {
        private readonly IUserCartMapping _UserCartMapping;

        public UserCartMappingController(IUserCartMapping UserCartMapping)
        {
            _UserCartMapping = UserCartMapping;
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(UserCartMappingModel objUserCartMappingModel)
        {
            return await _UserCartMapping.Add(objUserCartMappingModel);
        }

        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _UserCartMapping.GetAll();
        }

        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int UserCartMappingId)
        {
            return await _UserCartMapping.GetById(UserCartMappingId);
        }

        [HttpPut]
        public async Task<APIResponseModel> Update(UserCartMappingModel objUserCartMappingModel)
        {
            return await _UserCartMapping.Update(objUserCartMappingModel);
        }


        [HttpDelete]
        public async Task<APIResponseModel> Delete(int UserCartMappingId)
        {
            return await _UserCartMapping.Delete(UserCartMappingId);
        }
    }
}

