using ENT.BL.RegionSearch;
using ENT.BL.ServiceProviderAreaMapping;
using ENT.Model.Common;
using ENT.Model.CustomModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebAPI.Controllers.RegionSearch
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionSearchController : ControllerBase
    {
        private readonly IRegionSearch _regionSearch;
        public RegionSearchController(IRegionSearch regionSearch)
        {
            _regionSearch  = regionSearch;
        }
        [HttpGet("GetByState")]
        public async Task<APIResponseModel> GetByState(string StateName)
        {
            return await _regionSearch.GetByState(StateName);
        }

        [HttpGet("GetByCity")]
        public async Task<APIResponseModel> GetByCity(int StateId, string CityName)
        {
            return await _regionSearch.GetByCity(StateId, CityName);
        }

        [HttpGet("GetByArea")]
        public async Task<APIResponseModel> GetByArea(int CityId )
        {
            return await _regionSearch.GetByArea(CityId);
        }
    }
}
