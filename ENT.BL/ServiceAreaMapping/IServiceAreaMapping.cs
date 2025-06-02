using ENT.Model.Common;
using ENT.Model.ServiceAreaMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.ServiceAreaMapping
{
    public interface IServiceAreaMapping
    {
        Task<APIResponseModel> Add(ServiceAreaMappingModel objServiceAreaMapping);

        Task<APIResponseModel> GetAll();

        Task<APIResponseModel> GetById(int serviceAreaMappingId);

        Task<APIResponseModel> Delete(int serviceAreaMappingId);

        Task<APIResponseModel> Update(ServiceAreaMappingModel objServiceAreaMapping);
        Task<APIResponseModel> GetAreaBySearch(string name);

        Task<APIResponseModel> GetServicesByRegionType(string regionType, int regionId);
    }
}
