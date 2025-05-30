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
        // subcategoryid , service name should unique add and update, nency will take care
        Task<APIResponseModel> Add(ServicesModel objServices);
        Task<APIResponseModel> GetAll(); // user inner join
        Task<APIResponseModel> GetById(int ServiceId);  // string service name
        Task<APIResponseModel> Update(ServicesModel objServices);
        Task<APIResponseModel> Delete(int ServiceId);
    }
}
