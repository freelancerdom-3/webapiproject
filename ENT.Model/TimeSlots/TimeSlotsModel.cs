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
        public int SlotId { get; set; }
        public TimeOnly Time {  get; set; }
        public int? SlotExtrafee { get; set; }


    }
}
