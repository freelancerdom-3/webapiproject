﻿using ENT.BL.ServiceAreaMapping;
using ENT.Model.Common;
using ENT.Model.ServiceAreaMapping;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ServiceAreaMapping
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ServiceAreaMappingController : ControllerBase
    {
        private readonly IServiceAreaMapping _serviceAreaMapping;
        public ServiceAreaMappingController(IServiceAreaMapping serviceAreaMapping)
        {
            _serviceAreaMapping = serviceAreaMapping;
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(ServiceAreaMappingModel objServiceAreaMapping)
        {
            return await _serviceAreaMapping.Add(objServiceAreaMapping);
        }

        [HttpDelete]
        public async Task<APIResponseModel> Delete(int serviceAreaMappingId)
        {
            return await _serviceAreaMapping.Delete(serviceAreaMappingId);
        }

        [HttpGet("GetAll")]
        public async Task<APIResponseModel> GetAll()
        {
            return await _serviceAreaMapping.GetAll();
        }

        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int serviceAreaMappingId)
        {
            return await _serviceAreaMapping.GetById(serviceAreaMappingId);
        }

        [HttpPut]
        public async Task<APIResponseModel> Update(ServiceAreaMappingModel objServiceAreaMapping)
        {
            return await _serviceAreaMapping.Update(objServiceAreaMapping);
        }

        [HttpGet("GetAreaBySearch")]
        [AllowAnonymous]
        public async Task<APIResponseModel> GetAreaBySearch(string? name, int maxrecord, string? searchType)
        {
            return await _serviceAreaMapping.GetAreaBySearch(name, maxrecord,searchType);
        }

        [HttpGet("GetServicesByRegionType")]
        [AllowAnonymous]
        public async Task<APIResponseModel> GetServicesByRegionType(string regionType, int regionId)
        {
            return await _serviceAreaMapping.GetServicesByRegionType(regionType, regionId);
        }

    }
}
