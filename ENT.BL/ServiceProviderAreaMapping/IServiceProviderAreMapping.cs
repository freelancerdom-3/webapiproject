using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.Common;
using ENT.Model.ServiceProviderAreaMapping;

namespace ENT.BL.ServiceProviderAreaMapping
{
    public interface IServiceProviderAreMapping
    {
        Task<APIResponseModel> Add(ServiceProviderAreaMappingModel objServiceProviderAreaMapping);

        Task<APIResponseModel> GetAll();

        Task<APIResponseModel> GetById(int MappingId);

        Task<APIResponseModel> Delete(int MappingId);

        Task<APIResponseModel> Update(ServiceProviderAreaMappingModel objServiceProviderAreaMapping);
    }
}
