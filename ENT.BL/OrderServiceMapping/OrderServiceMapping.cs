using ENT.Model.Common;
using ENT.Model.CustomModel;
using ENT.Model.EntityFramework;
using ENT.Model.OrderID;
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
                List<ServiceQuantityViewModel> servicesList = objPlaceServiceOrderVeiwModel.servicesList;
                using(var connection = _context)
                {
                    //Generate Order ID at new order placed functionality
                    OrderIDModel newOrderID = new OrderIDModel();
                    //Add to new orderID to table
                    await connection.TblOrderIDS.AddRangeAsync(newOrderID);
                    //Save changes to table
                    await connection.SaveChangesAsync();

                    //At this point orderID table will have atleast one orderID
                    OrderIDModel orderIDObject = await connection.TblOrderIDS.OrderBy(x => x.OrderID).LastOrDefaultAsync();

                    foreach (var service in servicesList)
                    {
                        OrderServiceMappingModel orderServiceMapping = new OrderServiceMappingModel();
                        orderServiceMapping.OrderID = orderIDObject.OrderID;
                        orderServiceMapping.ServiceId = service.ServiceId;
                        orderServiceMapping.ServiceName = service.ServiceName;
                        orderServiceMapping.Price = service.Price;
                        orderServiceMapping.Quantity = service.Quantity;
                        orderServiceMapping.OrderID = 1; //<--- this denotes PENDING STATUS

                        await connection.TblOrderServiceMappings.AddAsync(orderServiceMapping);
                    }
                    await connection.SaveChangesAsync();
                }
                response.statusCode = 200;
                response.Message = "Services added to order table";
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
