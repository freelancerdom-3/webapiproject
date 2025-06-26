using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENT.Model.Fees
{
    public class FeesModel
    {
        [Key]
        public int FeesId { get; set; }
        public decimal StartRange { get; set; }
        public decimal EndRange { get; set;}
        public decimal Charge { get; set;}

    }
}
