using System.Runtime.CompilerServices;
using ENT.Model.Common;
using ENT.Model.Cart;
using ENT.BL.Cart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers.Cart
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartController : ControllerBase
    {
        private readonly ICart _cart;

        public CartController(ICart cart)
        {
            _cart = cart;
        }

        [HttpPost]
        public async Task<APIResponseModel> Add()
        {
            return await _cart.Add();
        }

        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _cart.GetAll();
        }

        [HttpPut]
        public async Task<APIResponseModel> Update(CartModel objCartModel)
        {
            return await _cart.Update(objCartModel);
        }


        [HttpDelete]
        public async Task<APIResponseModel> Delete(int CartId)
        {
            return await _cart.Delete(CartId);
        }
    }
}

