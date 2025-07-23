using ENT.Model.Common;
using ENT.Model.CustomModel;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.Order
{
    public class Order : IOrder
    {
        private readonly MyDBContext _context;
        public Order(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> GetConfirmedOrder(int OrderID)
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                //Main carrrier model/Object
                ConfirmedOrderViewModel confirmedOrder = new ConfirmedOrderViewModel();

                using (var connection = _context)
                {
                    //First check if orderID exists or not
                    bool orderExists = await connection.OrderDetailsViewModels.AnyAsync(x => x.OrderID == OrderID);
                    if (orderExists)
                    {
                        OrderDetailsViewModel orderDetails = await connection.OrderDetailsViewModels.FromSqlRaw($@"
                                SELECT orders.OrderID AS OrderID, 
                                orders.Date AS Date, 
                                orders.Time AS Time, 
                                orders.ItemTotal AS ItemTotal, 
                                orders.PlatformFee AS PlatformFee, 
                                orders.SubTotal AS SubTotal, os.OrderStatusName
                                FROM TblOrders orders
                                JOIN TblOrderStatus os
                                ON orders.OrderStatusId = os.OrderStatusID
                                WHERE orders.OrderID = {OrderID};
                        ").FirstAsync();
                        //Assign order detials to carrier model/object
                        confirmedOrder.OrderDetails = orderDetails;
                        //Fetch and assign services in that order to carrier model/Object
                        confirmedOrder.ServicesList = await connection.ServiceQuantityViewModels.FromSqlRaw($@"
                                SELECT osm.ServiceId AS ServiceId, 
                                osm.ServiceName AS ServiceName, 
                                osm.Price AS Price, 
                                osm.Quantity AS Quantity
                                FROM TblOrders orders
                                JOIN TblOrderServiceMapping osm
                                ON orders.OrderID = osm.OrderID
                                WHERE orders.OrderID = {OrderID};
                        ").ToListAsync();
                        response.statusCode = 200;
                        response.Data = confirmedOrder;
                    }
                    else
                    {
                        response.statusCode = 202;
                        response.Message = "OrderID not found";
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
