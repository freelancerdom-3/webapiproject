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
using ENT.BL.ServiceCartMapping;
using ENT.Model.ServiceCartMapping;

namespace ENT.BL.Cart
{
    public class Cart : ICart
    {
        private readonly MyDBContext _context;
        private readonly IServiceCartMapping _serviceCartMappingService;
        public Cart(MyDBContext context, IServiceCartMapping serviceCartMapping)
        {
            _context = context;
            _serviceCartMappingService = serviceCartMapping;
        }

        public async Task<APIResponseModel> Add()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    //Create new cart with price = 0.00;
                    CartModel cart = new CartModel();
                    cart.Price = 0.00m;
                    response.Data = cart;
                    await connection.TblCarts.AddAsync(cart);
                    await connection.SaveChangesAsync();
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

        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    response.Data = await connection.TblCarts.ToListAsync();
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

        public async Task<APIResponseModel> Delete(int cartId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    var deleteObject = await connection.TblCarts.FindAsync(cartId);
                    if (deleteObject == null)
                    {
                        response.Message = "id does not exists in cart table";
                        response.Data = false;
                        response.statusCode = 204;
                    }
                    else
                    {
                        APIResponseModel serviceCartResponse = await _serviceCartMappingService.GetByCartId(cartId);
                        if (serviceCartResponse.Data == null)
                        {
                            connection.TblCarts.Remove(deleteObject);
                            await connection.SaveChangesAsync();

                            response.Message = "Data deleted successfully";
                            response.Data = true;
                            response.statusCode = 202;
                        }
                        else
                        {
                            response.Message = "There are services in cart, so cart cannot be deleteed";
                            //412 Precondition Failed
                            response.statusCode = 412;
                            response.Data = false;
                        }
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

