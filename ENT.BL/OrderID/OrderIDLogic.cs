using ENT.Model.Common;
using ENT.Model.EntityFramework;
using ENT.Model.OrderID;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.OrderID
{
    public class OrderIDLogic : IOrderID
    {
        private readonly MyDBContext _context;
        
        public OrderIDLogic(MyDBContext context)
        {
            _context = context;
        }
        
        public async Task<APIResponseModel> GenerateOrderID()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    OrderIDModel newOrderID = new OrderIDModel();
                    await connection.TblOrderIDS.AddAsync(newOrderID);
                    await connection.SaveChangesAsync();
                    response.Data = await connection.TblOrderIDS.OrderBy(x => x.OrderID).LastOrDefaultAsync();
                }
                response.statusCode = 200;
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
