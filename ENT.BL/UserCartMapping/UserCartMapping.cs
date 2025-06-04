using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.UserCartMapping;
using ENT.Model.Common;
using ENT.BL.UserCartMapping;
using ENT.Model.EntityFramework;
using ENT.BL.ServiceCartMapping;
using ENT.BL.Cart;
using Microsoft.EntityFrameworkCore;
using ENT.Model.Cart;

namespace ENT.BL.UserCartMapping
{
    public class UserCartMapping : IUserCartMapping
    {
        private readonly MyDBContext _context;
        private readonly IServiceCartMapping _serviceCartMappingService;
        public UserCartMapping(MyDBContext context, IServiceCartMapping serviceCartMapping)
        {
            _context = context;
            _serviceCartMappingService = serviceCartMapping;
        }
        public async Task<APIResponseModel> Add(UserCartMappingModel objUserCartMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await connection.TblUserCartMappings.AddAsync(objUserCartMapping);
                    await connection.SaveChangesAsync();
                }

                response.Data = true;
                response.statusCode = 200;
                response.Message = "Data added successfully";
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

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    response.Data = _context.TblUserCartMappings.ToList();
                }


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

        public async Task<APIResponseModel> GetCartByUserId(int userId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var cartObject = await _context.TblUserCartMappings.Where(x => x.UserId == userId).FirstOrDefaultAsync();
                    if (cartObject == null)
                    {
                        response.Data = "userId "+ userId +" does not exists";
                    }
                    else
                    {
                        response.Data = cartObject;
                    }
                    await _context.SaveChangesAsync();
                }
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

        public async Task<APIResponseModel> Update(UserCartMappingModel objUserCartMapping)
        {

            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                   var cartObject = _context.TblUserCartMappings.Update(objUserCartMapping);
                    if (cartObject == null)
                    {
                        response.Data = "Id does not Exists";
                    }
                    else
                    {
                        response.Data = cartObject;
                    }
                    await _context.SaveChangesAsync();
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

        public async Task<APIResponseModel> DeleteByUserId(int userId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var deleteUserCart = await _context.TblUserCartMappings.Where(x => x.UserId == userId).FirstOrDefaultAsync();
                    if (deleteUserCart != null)
                    {
                        //Check if serivces exists in ServiceCartMappings table, if not then delete the user cart
                        bool servicesExists = await connection.TblServiceCartMappings.AnyAsync(x => x.CartId == deleteUserCart.CartId);
                        if (servicesExists == false)
                        {
                            connection.TblUserCartMappings.Remove(deleteUserCart);
                            await connection.SaveChangesAsync();
                            
                            response.Data = true;
                            response.Message = "Data deleted successfully";
                            response.statusCode = 202;
                        }
                        else
                        {
                            response.Data = false;
                            response.Message = "Cannot delete user cart mapping as cart contains services";
                        }

                    }
                    else
                    {
                        response.Data = false;
                        response.Message = "userId " + userId + " does not exists";
                        response.statusCode = 204;
                    }
                }
                
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
    }
}

