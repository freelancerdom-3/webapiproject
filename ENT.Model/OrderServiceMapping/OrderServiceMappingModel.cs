using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.OrderServiceMapping
{
    public class OrderServiceMappingModel
    {
        [Key]
        public int MappingID { get; set; }
        public int OrderID { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ServiceOrderStatusID { get; set; }
    }
}
