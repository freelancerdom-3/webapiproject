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
        // remove dependecy of service Id , paresh will take care
        Task<APIResponseModel> Add(OfferModel OfferUser); // one startdate should have only one offer
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int OfferId); // datetime startdate 
        Task<APIResponseModel> Update(OfferModel OfferUser);  // one startdate should have only one offer
        Task<APIResponseModel> Delete(int OfferId);
    }

}
