using ENT.Model.Common;
using ENT.Model.Offer;
using ENT.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.Offer
{

    public interface IOffer
    {
        Task<APIResponseModel> Add(OfferModel OfferUser);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int OfferId);
        Task<APIResponseModel> Update(OfferModel OfferUser);
        Task<APIResponseModel> Delete(int OfferId);
    }

}
