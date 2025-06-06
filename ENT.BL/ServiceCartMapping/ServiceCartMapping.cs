
using ENT.BL.Cart;
using ENT.Model.Cart;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.ServiceCartMapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ENT.BL.ServiceCartMapping
{
    public class ServiceCartMapping : IServiceCartMapping
    {
        private readonly MyDBContext _context;
        //private readonly ICart _cartService;
        public ServiceCartMapping(MyDBContext context)
        {
            _context = context;
            //_cartService = cartService;
        }

        //Update cart method that comes to effect after any kind of change in service cart mappings table
        public async Task updateCart(int cartId)
        {
            using(MyDBContext connection = _context)
            {
                // find all service for cart
                // sum of all service price
                //update cart table
                List<ServiceCartMappingModel> listOfServicesInGivenCartId = await connection.TblServiceCartMappings
                                                        .Where(x => x.CartId == cartId)
                                                        .ToListAsync();
                decimal subTotal = 0;
                CartModel? cart = await connection.TblCarts.Where(x => x.CartId == cartId).FirstOrDefaultAsync();
                if (listOfServicesInGivenCartId.Count > 0)
                {
                    foreach (var service in listOfServicesInGivenCartId)
                    {
                        subTotal += service.Quantity * service.Price;
                    }
                }
                if (cart != null)
                {
                    //Here price is updated
                    cart.Price = subTotal;
                    //Here changes are saved
                    await connection.SaveChangesAsync();

                    //It creates circular dependency
                    //await _cartService.Update(cart);
                }
            }
        }

        public async Task<APIResponseModel> Add(ServiceCartMappingModel objServiceCartMapping)
        {

            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    await connection.TblServiceCartMappings.AddAsync(objServiceCartMapping);
                    await connection.SaveChangesAsync();
                    //Logic to update the respective cart's subtotal amount
                    //Update status of cart after every change
                    await updateCart(objServiceCartMapping.CartId);
                    
                }

                response.Data = true;
                response.Message = "Data created successfully";
                response.statusCode = 201;
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
                    response.Data = await connection.TblServiceCartMappings.ToListAsync();
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

        public async Task<APIResponseModel> GetByCartId(int cartId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                var cartServiceObject = await _context.TblServiceCartMappings.Where(x => x.CartId == cartId).ToListAsync();
                if (cartServiceObject == null)
                {
                    response.Message = "cartId " + cartId + " does not exists";
                    response.statusCode = 204;
                }
                else
                {
                    response.Data = cartServiceObject;
                    response.statusCode = 200;
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

        public async Task<APIResponseModel> Update(ServiceCartMappingModel objServiceCartMapping)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    bool updateObjectExists = await connection.TblServiceCartMappings.AnyAsync(x => x.CartId == objServiceCartMapping.CartId);
                    if (updateObjectExists)
                    {
                        connection.TblServiceCartMappings.Update(objServiceCartMapping);
                        await connection.SaveChangesAsync();
                        response.Message = "Data updated successfully";
                        response.statusCode = 200;
                        //Update status of cart after every change
                        await updateCart(objServiceCartMapping.CartId);
                    }
                    else
                    {
                        response.statusCode = 204;
                        response.Message = "Data does not exists";
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

        public async Task<APIResponseModel> Delete(int serviceCartMappingId)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {

                    bool deleteObjectExists = await connection.TblServiceCartMappings.AnyAsync(x => x.MappingId == serviceCartMappingId);

                    // find all service for cart
                    // sum of all service price
                    //update cart table


                    if (deleteObjectExists)
                    {
                        ServiceCartMappingModel? deleteObject = connection.TblServiceCartMappings.Where(x => x.MappingId == serviceCartMappingId).FirstOrDefault();
                        _ = connection.TblServiceCartMappings.Remove(deleteObject);
                        response.Message = "Service deleted successfully";
                        response.statusCode = 200;
                        await connection.SaveChangesAsync();

                        //Update cart with latest services total
                        await updateCart(deleteObject.CartId);
                    }
                    else
                    {
                        response.Message = "Data does not exists";
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
