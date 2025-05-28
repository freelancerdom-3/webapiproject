using ENT.Model.Common;
using ENT.Model.EntityFramework;
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
        private readonly MyDBContext _context;
        public User(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> Add(UserModel objUser)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await connection.TblUsers.AddAsync(objUser);
                    await connection.SaveChangesAsync();
                }
                response.Data = true;
                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }

        public Task<APIResponseModel> Delete(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            response.Data = _context.TblUsers.ToList();
            response.statusCode = 200;
            return response;
        }

        public Task<APIResponseModel> GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<APIResponseModel> Update(UserModel objUser)
        {
            APIResponseModel response = new APIResponseModel();
            _context.TblUsers.Update(objUser);
            await _context.SaveChangesAsync();
            response.Data = true;
            response.statusCode = 200;
            return response;
        }
    }
}
