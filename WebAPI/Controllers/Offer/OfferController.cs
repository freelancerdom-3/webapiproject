using ENT.BL.Offer;
using ENT.Model.Common;
using ENT.Model.Offer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers.Offers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOffer _offer;
        public OfferController(IOffer offer)
        {
            _offer = offer;
        }

        [HttpPost]
        public async Task<APIResponseModel> Add(OfferModel objOfferModel)
        {
            return await _offer.Add(objOfferModel);
        }

        [HttpPut]
        public async Task<APIResponseModel> Update(OfferModel objOfferModel)
        {
            return await _offer.Update(objOfferModel);
        }
        [HttpDelete]
        public async Task<APIResponseModel> Delete(int OfferId)
        {
            return await _offer.Delete(OfferId);
        }
        [HttpGet("GetById")]
        public async Task<APIResponseModel> GetById(int OfferId)
        {
            return await _offer.GetById(OfferId);
        }
        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _offer.GetAll();
        }

    }
}
