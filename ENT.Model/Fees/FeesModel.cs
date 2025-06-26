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
        public string Range { get; set;}
        public int Charge { get; set;}
    }
}
