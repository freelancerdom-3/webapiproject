using ENT.BL.ServiceCartMapping;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.BL.Fees
{
    public class Fees : IFees
    {
        private readonly MyDBContext _context;

        public Fees(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel>GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (var connection = _context)
                {
                    response.Data = connection.TblFees.ToList();
                }


                response.statusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.statusCode = 400;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
