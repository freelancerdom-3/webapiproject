using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.Common;
using ENT.Model.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace ENT.BL.TimeSlots
{
    public class TimeSlots : ITimeSlots
    {
        private readonly MyDBContext _context;
        public TimeSlots(MyDBContext context)
        {
            _context = context;
        }
        public async Task<APIResponseModel> GetAll()
        {
            APIResponseModel response = new APIResponseModel();
            try
            {
                using (MyDBContext connection = _context)
                {
                    response.Data = await _context.TblTimeSlots.ToListAsync();
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
