﻿using System.Runtime.CompilerServices;
using ENT.Model.Common;
using ENT.Model.ServiceCartMapping;
using ENT.BL.ServiceCartMapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using ENT.Model.CustomModel;


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
        [AllowAnonymous]
        public async Task<APIResponseModel> GetAll()
        {
            return await _ServiceCartMapping.GetAll();
        }

        [HttpGet("GetByCartId")]
        [AllowAnonymous]
        public async Task<APIResponseModel> GetByCartId(int ServiceCartMappingId)
        {
            return await _ServiceCartMapping.GetByCartId(ServiceCartMappingId);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<APIResponseModel> Update(ServiceCartMappingModel objServiceCartMappingModel)
        {
            return await _ServiceCartMapping.Update(objServiceCartMappingModel);
        }


        [HttpDelete]
        [AllowAnonymous]
        public async Task<APIResponseModel> Delete(DeleteServiceViewModel objDeleteServiceViewModel)
        {
            return await _ServiceCartMapping.Delete(objDeleteServiceViewModel);
        }

        [HttpPost("AddServicesByList")]
        public async Task<APIResponseModel> AddServicesByList([FromBody]CartServiceQuantityViewModel objCartServiceViewModel)
        {
            return await _ServiceCartMapping.AddServicesByList(objCartServiceViewModel);
        }

        [HttpDelete("DeletePlacedServices")]
        public async Task<APIResponseModel> DeletePlacedServices([FromBody]DeletePlacedServicesViewModel objDeletePlacedServices)
        {
            return await _ServiceCartMapping.DeletePlacedServices(objDeletePlacedServices);
        }
    }
}
