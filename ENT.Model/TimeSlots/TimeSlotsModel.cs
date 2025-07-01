using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.TimeSlots
{
    public class TimeSlotsModel
    {
        [Key]
        public int TimeSlotId { get; set; }
        public string Time {  get; set; }
        public Boolean SpecialSlot { get; set; }


    }
}
