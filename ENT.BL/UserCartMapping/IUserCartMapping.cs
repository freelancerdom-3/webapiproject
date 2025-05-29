using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.UserCartMapping;
using ENT.Model.Common;

namespace ENT.BL.UserCartMapping
{
    public interface IUserCartMapping
    {
        Task<APIResponseModel> Add(UserCartMappingModel ObjUserCartMapping);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int UserCartMappingId);
        Task<APIResponseModel> Update(UserCartMappingModel ObjUserCartMapping);
        Task<APIResponseModel> Delete(int UserCartMappingId);
    }
}


