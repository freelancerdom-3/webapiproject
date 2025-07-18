using ENT.Model.Common;
using ENT.Model.CustomModel;
using ENT.Model.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.User
{
    public interface IUser
    {
        Task<APIResponseModel> Add(UserModel objUser);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int userId);
        Task<APIResponseModel> Update(UserModel objUser);
        Task<APIResponseModel> Delete(int userId);
       
    }
}
