using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.ServiceCartMapping;
using ENT.Model.Common;

namespace ENT.BL.ServiceCartMapping
{
    public interface IServiceCartMapping
    {
        Task<APIResponseModel> Add(ServiceCartMappingModel ObjServiceCartMapping);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int ServiceCartMappingId);
        Task<APIResponseModel> Update(ServiceCartMappingModel ObjServiceCartMapping);
        Task<APIResponseModel> Delete(int ServiceCartMappingId);
    }
}

