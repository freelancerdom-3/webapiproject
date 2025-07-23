using ENT.Model.Common;
using ENT.Model.CustomModel;
using ENT.Model.EntityFramework;
using ENT.Model.Order;
using ENT.Model.OrderServiceMapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.OrderServiceMapping
{
    public class OrderServiceMapping : IOrderServiceMapping
    {
        private readonly MyDBContext _context;
        public OrderServiceMapping(MyDBContext context)
        {
            _context = context;
        }

        public async Task<APIResponseModel> AddServicesInOrder(PlaceServiceOrderViewModel objPlaceServiceOrderVeiwModel)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                //This orderId is sent as response
                int confirmedOrderId = 0;
                List<ServiceQuantityViewModel> servicesList = objPlaceServiceOrderVeiwModel.ServicesList;
                using(var connection = _context)
                {
                    /*First place order so orderId is generated and then map this OrderId with services 
                     * and insert in OrderServiceMapping table.
                     * Create new Order object and set all the values to Object properties
                     */
                    OrderModel newOrder = new OrderModel();
                    newOrder.EndUserId = objPlaceServiceOrderVeiwModel.EndUserId;
                    newOrder.Date = objPlaceServiceOrderVeiwModel.Date;
                    newOrder.Time = objPlaceServiceOrderVeiwModel.Time;
                    newOrder.SubCategoryId = objPlaceServiceOrderVeiwModel.SubCategoryId;
                    newOrder.ItemTotal = objPlaceServiceOrderVeiwModel.ItemTotal;
                    newOrder.PlatformFee = objPlaceServiceOrderVeiwModel.PlatformFee;
                    newOrder.SubTotal = objPlaceServiceOrderVeiwModel.SubTotal;
                    newOrder.OrderStatusID = 1; //<---- This denotes Order is Upcoming
                    //Insert this object to table
                    await connection.TblOrders.AddAsync(newOrder);
                    //Save changes so that later on this User's OrderId can be tracked
                    await connection.SaveChangesAsync();

                    //At this point, the order is inserted to table so we can fetch the latest placed order for this user.
                    int placedOrderId = await connection.TblOrders.Where(x => x.EndUserId == objPlaceServiceOrderVeiwModel.EndUserId).OrderBy(x => x.OrderId).Select(x => x.OrderId).LastOrDefaultAsync();
                    confirmedOrderId = placedOrderId;
                    foreach (var service in servicesList)
                    {
                        OrderServiceMappingModel orderServiceMapping = new OrderServiceMappingModel();
                        orderServiceMapping.OrderID = placedOrderId;
                        orderServiceMapping.ServiceId = service.ServiceId;
                        orderServiceMapping.ServiceName = service.ServiceName;
                        orderServiceMapping.Price = service.Price;
                        orderServiceMapping.Quantity = service.Quantity;
                        //1 <-- PENDING 
                        //2 <-- IN-PROGRESS
                        //3 <-- COMPLETED
                        orderServiceMapping.ServiceOrderStatusID = 1; //<--- this denotes PENDING STATUS

                        await connection.TblOrderServiceMappings.AddAsync(orderServiceMapping);
                    }
                    await connection.SaveChangesAsync();
                }
                response.Data = confirmedOrderId;
                response.statusCode = 200;
                response.Message = "Order placed successfully";
                return response;
            }
            catch(Exception ex)
            {
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
