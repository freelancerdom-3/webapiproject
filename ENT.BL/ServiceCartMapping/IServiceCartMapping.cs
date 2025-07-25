using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.ServiceCartMapping;
using ENT.Model.Common;
using ENT.Model.CustomModel;

namespace ENT.BL.ServiceCartMapping
{
    public interface IServiceCartMapping
    {
        Task<APIResponseModel> Add(ServiceCartMappingModel ObjServiceCartMapping);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetByCartId(int cartId);
        Task<APIResponseModel> Update(ServiceCartMappingModel ObjServiceCartMapping);
        Task<APIResponseModel> Delete(DeleteServiceViewModel objDeleteServiceViewModel);
        Task<APIResponseModel> AddServicesByList(CartServiceQuantityViewModel objCartServiceViewModel);
        Task<APIResponseModel> DeletePlacedServices(DeletePlacedServicesViewModel objDeletePlacedServices);
    }
}

