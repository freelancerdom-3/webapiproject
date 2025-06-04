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
       
       
        Task<APIResponseModel> GenerateOtpForAdmin(string mobileNumber);
        Task<APIResponseModel> GenerateOtpForEndUser(string mobileNumber);
        Task<APIResponseModel> GenerateOtpForServiceProvider(string mobileNumber);
        Task<APIResponseModel> Verify(int Otp, string mobileNumber);
    }
}
