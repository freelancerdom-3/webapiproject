using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.OrderID
{
    public class OrderIDModel
    {
        [Key]
        public int OrderID { get; set; }
    }
}
