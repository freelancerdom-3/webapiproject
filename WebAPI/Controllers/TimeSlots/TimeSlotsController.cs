using ENT.BL.TimeSlots;
using ENT.Model.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.TimeSlots
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class TimeSlotsController:ControllerBase
    {
        private readonly ITimeSlots _TimeSlots;
        public TimeSlotsController(ITimeSlots timeSlots)
        {
            _TimeSlots = timeSlots;
        }

        [HttpGet]
        public async Task<APIResponseModel> GetAll()
        {
            return await _TimeSlots.GetAll();
        }
    }
}
