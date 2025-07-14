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
using ENT.Model.UserCartMapping;

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

        /*This method will return a cart if not assigned then it will generate new one 
         * and it will assign it to the userId
        */
        public async Task<APIResponseModel> GenerateCartByUserId(int userId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    bool userExists = await connection.TblUsers.AnyAsync(x => x.UserId == userId);
                    if(userExists)
                    {
                        UserCartMappingModel? cartExistsForUser = await connection.TblUserCartMappings.Where(x => x.UserId == userId).FirstOrDefaultAsync();
                        if (cartExistsForUser != null)
                        {
                            response.Data = cartExistsForUser;
                        }
                        else
                        {
                            //Create new cart to add it to 
                            CartModel cart = new CartModel();
                            cart.Price = 0.00m;
                            //Add new empty cart
                            await connection.TblCarts.AddAsync(cart);
                            //Save changes
                            await connection.SaveChangesAsync();

                            //A new cart is added and its mapped with user
                            UserCartMappingModel userCartMapping = new UserCartMappingModel();

                            //Fetch the latest cartId value get the lastly updated cart.
                            CartModel latestCart = await connection.TblCarts.OrderBy(x => x.CartId).LastOrDefaultAsync();
                            userCartMapping.CartId = latestCart.CartId;
                            userCartMapping.UserId = userId;

                            //Assign data to payload
                            response.Data = latestCart;

                            //Add value to userCartMappings table.
                            await connection.TblUserCartMappings.AddAsync(userCartMapping);
                            //Save changes
                            await connection.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        response.Message = "User does not exists";
                    }
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

