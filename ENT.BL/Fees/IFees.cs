using ENT.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.Fees
{
     public  interface IFees
    {
        Task<APIResponseModel> GetAll();
    }
}
