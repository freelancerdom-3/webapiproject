using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.Common;
using ENT.Model.Services;

namespace ENT.BL.Services
{
    public interface IServices
    {
        Task<APIResponseModel> Add(ServicesModel objServices);
        Task<APIResponseModel> GetAll();
        Task<APIResponseModel> GetById(int ServiceId);
        Task<APIResponseModel> Update(ServicesModel objServices);
        Task<APIResponseModel> Delete(int ServiceId);
    }
}
