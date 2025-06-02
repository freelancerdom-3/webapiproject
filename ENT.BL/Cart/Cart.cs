using ENT.Model.Common;
using ENT.Model.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ENT.BL.Cart
{
    public class Cart : ICart
    {
        private readonly MyDBContext _context;
        public Cart(MyDBContext context)
        {
            _context = context;
        }

        public async Task<APIResponseModel> Add(CartModel objCart)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await connection.TblCarts.AddAsync(objCart);
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

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    response.Data = connection.TblCarts.ToList();
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

        public async Task<APIResponseModel> GetById(int CartId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var cartObject = await connection.TblCarts.Where(x => x.CartId == CartId).FirstOrDefaultAsync();
                    if (cartObject == null)
                    {
                        response.Data = "Id does not exists";
                        response.statusCode = 204;
                    }
                    else
                    {
                        response.Data = cartObject;
                        response.statusCode = 200;
                    }
                }
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

        public async Task<APIResponseModel> Update(CartModel objCart)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    connection.TblCarts.Update(objCart);
                    await connection.SaveChangesAsync();
                }
                response.Message = "Data updated successfully";
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

        public async Task<APIResponseModel> Delete(int CartId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var deleteObject = await _context.TblCarts.FindAsync(CartId);
                    if (deleteObject == null)
                    {
                        response.Message = "id does not exists";
                        response.Data = false;
                        response.statusCode = 204;
                    }
                    else
                    {
                        connection.TblCarts.Remove(deleteObject);
                        response.Message = "Data deleted successfully";
                        response.Data = false;
                        response.statusCode = 200;
                       
                    }
                    await connection.SaveChangesAsync();
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

