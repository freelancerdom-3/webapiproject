
using Azure;
using ENT.BL.Cart;
using ENT.Model.Cart;
using ENT.Model.Common;
using ENT.Model.CustomModel;
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
        //public async Task updateCart(int cartId)
        //{
        //    using(MyDBContext connection = _context)
        //    {
        //        // find all service for cart
        //        // sum of all service price
        //        //update cart table
        //        List<ServiceCartMappingModel> listOfServicesInGivenCartId = await connection.TblServiceCartMappings
        //                                                .Where(x => x.CartId == cartId)
        //                                                .ToListAsync();
        //        decimal subTotal = 0;
        //        CartModel? cart = await connection.TblCarts.Where(x => x.CartId == cartId).FirstOrDefaultAsync();
        //        if (listOfServicesInGivenCartId.Count > 0)
        //        {
        //            foreach (var service in listOfServicesInGivenCartId)
        //            {
        //                subTotal += service.Quantity * service.Price;
        //            }
        //        }
        //        if (cart != null)
        //        {
        //            //Here price is updated
        //            cart.Price = subTotal;
        //            //Here changes are saved
        //            await connection.SaveChangesAsync();

        //            //It creates circular dependency
        //            //await _cartService.Update(cart);
        //        }
        //    }
        //}

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
                    //await updateCart(objServiceCartMapping.CartId);
                    
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
                    ServiceCartMappingModel? updateExistingObject = await connection.TblServiceCartMappings.Where(x => x.CartId == objServiceCartMapping.CartId && x.ServiceId == objServiceCartMapping.ServiceId).FirstOrDefaultAsync();
                    if (updateExistingObject != null)
                    {
                        updateExistingObject.Quantity = objServiceCartMapping.Quantity;
                        connection.TblServiceCartMappings.Update(updateExistingObject);
                        await connection.SaveChangesAsync();
                        response.Message = "Data updated successfully";
                        response.statusCode = 200;
                        //Update status of cart after every change
                        //await updateCart(objServiceCartMapping.CartId);
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

        public async Task<APIResponseModel> Delete(DeleteServiceViewModel objDeleteServiceViewModel)
        {
            int cartId = objDeleteServiceViewModel.CartId;
            int serviceId = objDeleteServiceViewModel.ServiceId;
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {

                    ServiceCartMappingModel? existingService = await connection.TblServiceCartMappings.FirstOrDefaultAsync(x => x.CartId == cartId && x.ServiceId == serviceId);

                    // find all service for cart
                    // sum of all service price
                    //update cart table


                    if (existingService != null)
                    {
                        _ = connection.TblServiceCartMappings.Remove(existingService);
                        response.Message = "Service deleted successfully";
                        response.statusCode = 200;
                        await connection.SaveChangesAsync();

                        //Update cart with latest services total
                        //await updateCart(deleteObject.CartId);
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

        /*This API is responsible to receive list of services, and send this response as 
         * list of object {subCategoryId, subCategoryName, subCategoryImageName, services[which are under this subCategoryId]}
        */
        public async Task<APIResponseModel> AddServicesByList(CartServiceQuantityViewModel objCartServiceViewModel)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                //Fetch data from the received object
                int cartId = objCartServiceViewModel.CartId;
                List<ServiceQuantityViewModel> servicesList = objCartServiceViewModel.ServiceQuantityList;

                using (var connection = _context)
                {
                    //Initial cart state
                    int initialCartServicesCount = await connection.TblServiceCartMappings.CountAsync(x => x.CartId == cartId);


                    /* Update services in UI's cart first with database cart
                     */
                    //This means user added some services to cart without logging-in so process of merging them
                    if(servicesList != null && servicesList.Count > 0)
                    {

                        // Step 1: Get all existing mappings for this cartId in a map
                        var existingMappings = await connection.TblServiceCartMappings
                            .Where(s => s.CartId == cartId)
                            .ToDictionaryAsync(s => s.ServiceId);

                        // Step 2: Iterate and add/update
                        /* If existing mappings are empty, then simply create new object and add it 
                         */
                        foreach (var item in servicesList)
                        {
                            if (existingMappings.TryGetValue(item.ServiceId, out var existingMapping))
                            {
                                // Update existing
                                existingMapping.Quantity = item.Quantity;
                                existingMapping.Price = item.Price;

                                connection.TblServiceCartMappings.Update(existingMapping);
                            }
                            else
                            {
                                // Add new
                                var newService = new ServiceCartMappingModel
                                {
                                    ServiceId = item.ServiceId,
                                    CartId = cartId,
                                    Quantity = item.Quantity,
                                    Price = item.Price
                                };

                                await connection.TblServiceCartMappings.AddAsync(newService);
                            }
                        }

                        // Save changes when all the services are merged to cart
                        await connection.SaveChangesAsync();
                    }

                    /*Here I will only carry out the response generation operation if cart had some data previously, otherwise the
                     * UI's cart is already up to date, means no data is missing to be considered.
                    */
                    List<SubCategoryServiceQuantityViewModel> subCategoryServiceQuantityListToBeSentToUpdateCart = new List<SubCategoryServiceQuantityViewModel>(); 
                    if (initialCartServicesCount > 0)
                    {
                        /*Here there will be the logic of generating the final response that will be containing
                         * the response object {subCategoryId, subCategoryName, subCategoryImageName, services[which are under this subCategoryId]}
                        */

                        /*Now we have to fetch all the services on the basis of the subCategoryIds so first get all the subCategoryIds that 
                         * are there with services in current cart
                        */
                        //Step - 1 ---> get all service Ids from cart, at this point I will have updated all the services with existing services
                        List<int> serviceListIdsFromCart = await connection.TblServiceCartMappings.Where(x => x.CartId == cartId).Select(x => x.ServiceId).ToListAsync();

                        //Step - 2 Fetch all unique subCategoryIds in 
                        HashSet<int> subCategoryIdsSet = new HashSet<int>();
                        for (int i = 0; i < serviceListIdsFromCart.Count; i++)
                        {
                            int subCategoryId = (int)await connection.TblServices.Where(x => x.ServiceId == serviceListIdsFromCart[i]).Select(x => x.MainSubCategoryId).FirstAsync();
                            subCategoryIdsSet.Add(subCategoryId);
                        }


                        //Step - 3
                        //Now get subCategoryImageName data and from SubcategoryId ----> get services that have this subCategoryId
                        
                        foreach(int subCategoryIdForCartService in subCategoryIdsSet)
                        {
                            SubCategoryServiceQuantityViewModel subCategoryServiceQuantityItem = new SubCategoryServiceQuantityViewModel();
                            subCategoryServiceQuantityItem.SubCategoryImageNameData = await connection.SubCategoryImageNameViewModels.FromSqlRaw($@"
                                SELECT sc.SubCategoryId AS SubCategoryId, sc.SubCategoryName AS SubCategoryName, IName.ImageName AS SubCategoryImageName
                                FROM TblSubCategorys sc
                                JOIN TblImageNames IName
                                ON sc.SubCategoryId = IName.CategorizedTypeId
                                AND IName.CategorizedTypeName = 'SubCategory'
                                AND sc.SubCategoryId = {subCategoryIdForCartService}
                            ").FirstAsync();
                            //Fetch list of services for this SubCategoryId
                            subCategoryServiceQuantityItem.serviceQuantityList = await connection.ServiceQuantityViewModels.FromSqlRaw($@"
                                SELECT se.ServiceId AS ServiceId, se.ServiceName AS ServiceName, se.Price AS Price, scm.Quantity AS Quantity
                                FROM TblServiceCartMappings scm
                                JOIN TblServices se
                                ON se.ServiceId = scm.ServiceId
                                JOIN TblSubCategorys sc
                                ON se.MainSubCategoryId = sc.SubCategoryId
                                WHERE sc.SubCategoryId = {subCategoryIdForCartService}
                            ").ToListAsync();
                            subCategoryServiceQuantityListToBeSentToUpdateCart.Add(subCategoryServiceQuantityItem);
                        }

                    }
                    /*This response will only contain data to be sent if there was some data in cart already other wise simply cart is 
                     * in updated state.
                    */
                    response.Data = subCategoryServiceQuantityListToBeSentToUpdateCart;


                }
                response.statusCode = 200;
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
    }
}
