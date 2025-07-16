using ENT.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.OrderID
{
    public interface IOrderID
    {
        //Only to generate new OrderID
        Task<APIResponseModel> GenerateOrderID();
    }
}
