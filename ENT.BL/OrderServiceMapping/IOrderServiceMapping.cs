using ENT.Model.Common;
using ENT.Model.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.OrderServiceMapping
{
    public interface IOrderServiceMapping
    {
        Task<APIResponseModel> AddServicesInOrder(PlaceServiceOrderViewModel objPlaceServiceOrderVeiwModel);
    }
}
