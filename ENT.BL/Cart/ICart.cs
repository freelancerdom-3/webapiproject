using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.Common;
using ENT.Model.Cart;

namespace ENT.BL.Cart
{
    public interface ICart
    { 

        //Hemil will take care
        Task<APIResponseModel> Add();
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int CartId);
        Task<APIResponseModel> Update(CartModel ObjCart);
        Task<APIResponseModel> Delete(int CartId);
    }

}
