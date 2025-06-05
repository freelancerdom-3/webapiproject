using ENT.BL.User;
using ENT.Model.Common;
using ENT.Model.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(UserModel objUserModel)
        {
            return await _user.Add(objUserModel);
        }
        [HttpPut]
        public async Task<APIResponseModel> Update(UserModel objUserModel)
        {
            return await _user.Update(objUserModel);
        }
        [HttpDelete]
        public async Task<APIResponseModel> Delete(int userId)
        {
            return await _user.Delete(userId);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int userId)
        {
            return await _user.GetById(userId);
        }
        [HttpGet]
        [Authorize]
        public async Task<APIResponseModel> GetAll()
        {
            return await _user.GetAll();
        }


    }
}
