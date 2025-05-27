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
    public class Otp : IOtp
    {
        public Otp()
        {
            
        }
        public async Task<APIResponseModel> Add(OtpModel objOtp)
        {
            throw new NotImplementedException();
        }
        public Task<APIResponseModel> GetById(int OtpId)
        {
            throw new NotImplementedException();
        }

        public Task<APIResponseModel> Update(OtpModel objOtp)
        {
            throw new NotImplementedException();
        }
    }
}
