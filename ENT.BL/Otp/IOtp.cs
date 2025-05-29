using ENT.Model.Common;
using ENT.Model.Otp;
using ENT.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.Otp
{
    public interface IOtp
    {
       
        Task<APIResponseModel> GetById(int OtpId);
        Task<APIResponseModel> Add(OtpModel objOtp);
        Task<APIResponseModel> Verify(int Otp, string mobileNumber);
    }
}
