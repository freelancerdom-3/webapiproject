using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
                //using (MyDBContext connection = _context)
                //{
                //    await connection.TblUsers.AddAsync(objUser);
                //    await connection.SaveChangesAsync();
                //}

                //This is a child module as request will not hit directly on this one
                //The caller parent module will make sure to dispose the context object
                await _context.TblUsers.AddAsync(objUser);
                await _context.SaveChangesAsync();

                response.Data = true;
                response.statusCode = 200;
                response.Message = "Data inserted successfully";
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

        public async Task<APIResponseModel> Delete(int userId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    UserModel? userExists = await connection.TblUsers.FirstOrDefaultAsync(x => x.UserId == userId);
                    if (userExists != null)
                    {
                        connection.TblUsers.Remove(userExists);

                        await connection.SaveChangesAsync();

                        response.Message = "Data deleted successfully";
                    }
                    else
                    {
                        response.Data = true;
                        response.Message = "Id " + userId + " does not exists";
                    }
                    response.statusCode = 200;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.statusCode = 400;
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using(MyDBContext connection = _context)
                {
                    response.Data = await _context.TblUsers.ToListAsync();
                }
                response.statusCode = 200;
                return response;
            }
            catch(Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<APIResponseModel> GetById(int userId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using(MyDBContext connection = _context)
                {
                    UserModel? existingUser = await connection.TblUsers.FirstOrDefaultAsync(x => x.UserId == userId);
                    if (existingUser != null)
                    {
                        response.Data = existingUser;
                    }
                    else
                    {
                        response.Data = false;
                        response.Message = "Id " + userId + " does not exists";
                    }
                    response.statusCode = 200;
                }
                return response;
            }
            catch(Exception ex){
                response.statusCode = 400;
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }

        //Get user by mobile number

        public async Task<APIResponseModel> Update(UserModel objUser)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using(MyDBContext connection = _context)
                {
                    UserModel? existingUser = await connection.TblUsers.FirstOrDefaultAsync(x => x.UserId == objUser.UserId);
                    if (existingUser != null)
                    {
                        existingUser.MobileNumber = objUser.MobileNumber;
                        existingUser.FullName = objUser.FullName;
                        existingUser.DateOfBirth = objUser.DateOfBirth;
                        existingUser.Email = objUser.Email;
                        //User won't be able to update role type
                        //existingUser.UserTypeId = objUser.UserTypeId;
                        //Update user by saving changes
                        await connection.SaveChangesAsync();

                        response.Message = "Data updated successfully";
                    }
                    else
                    {
                        response.Message = "User with id " + objUser.UserId + " does not exists";
                    }
                    response.statusCode = 200;
                }
                return response;
            }
            catch(Exception ex)
            {
                response.statusCode = 400;
                response.Message = ex.Message;
                response.Data = false;
                return response;
            }
        }


        //public async Task<APIResponseModel> GetAll(string? searchBy = null)
        //{
        //    APIResponseModel responseModel = new();
        //    try
        //    {
        //        List<GetTblUserViewModel> lstUsers = new();
        //        using (var connection = _hsmDbContext)
        //        {
        //            //lstUsers = string.IsNullOrEmpty(searchBy)? connection.TblUsers.ToList():
        //            //    connection.TblUsers.Where(x=>x.FullName.ToLower()==searchBy.ToLower()).
        //            //    ToList();

        //            lstUsers = connection.GetTblUserViewModel.FromSqlRaw($@"SELECT tuser.*,trole.rolename 
        //            FROM [HSMDB].[dbo].[TblUser] tuser
        //            inner join tblrole trole on trole.roleid=tuser.roleid where RoleName like '%{searchBy}%'").ToList();
        //            responseModel.Data = lstUsers;
        //            responseModel.StatusCode = HttpStatusCode.OK;
        //            responseModel.Message = "Successfully";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        responseModel.StatusCode = HttpStatusCode.InternalServerError;
        //        responseModel.Message = ex.InnerException.Message;
        //        responseModel.Data = null;
        //    }
        //    return responseModel;
        //}

        //public class GetTblUserViewModel
        //{
        //    [Key]
        //    public int UserId { get; set; }
        //    public string? FullName { get; set; }
        //    public string? Email { get; set; }
        //    public string? Password { get; set; }
        //    public string? RoleName { get; set; }
        //}

        //public DbSet<GetTblUserViewModel> GetTblUserViewModel { get; set; }
    }
}
