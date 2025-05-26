using ENT.Model.Common;
using ENT.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.User
{
    public class User : IUser
    {
        public User()
        {
                
        }
        public async Task<APIResponseModel> Add(UserModel objUser)
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> Delete(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> Update(UserModel objUser)
        {
            throw new NotImplementedException();
        }
    }
}
