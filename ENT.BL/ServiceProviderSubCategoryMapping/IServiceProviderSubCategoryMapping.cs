using ENT.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.ServiceProviderSubCategoryMapping
{
    public interface IServiceProviderSubCategoryMapping
    {
        Task<APIResponseModel> GetByArea(string AreaName);
        Task<APIResponseModel> GetBySubCategoryName(string SubCategoryName);

    }
}
