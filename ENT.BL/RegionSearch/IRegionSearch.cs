using ENT.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.RegionSearch
{
    public interface IRegionSearch
    {
         Task<APIResponseModel> GetByState(string StateName);
        Task<APIResponseModel> GetByCity(int StateId, string CityName);
        Task<APIResponseModel>GetByArea(int CityId );
    }
}
