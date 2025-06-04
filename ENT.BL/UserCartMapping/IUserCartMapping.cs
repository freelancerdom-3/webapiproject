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
        Task<APIResponseModel> GetCartByUserId(int userId);
        Task<APIResponseModel> Update(UserCartMappingModel ObjUserCartMapping);
        Task<APIResponseModel> DeleteByUserId(int userId);
    }
}


