using ENT.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.ImageName
{
    public interface IImageName
    {
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetByIdAndType(int categorizedTypeId, string categorizedTypeName);
    }
}
