using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT.Model.Common;

namespace ENT.BL.TimeSlots
{
    public interface ITimeSlots
    {
        Task<APIResponseModel> GetAll();

    }
}
