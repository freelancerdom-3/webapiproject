using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.Order
{
    public class OrderModel
    {
        [Key]
        public int OrderId { get; set; }
        public int EndUserId { get; set; }
        public DateOnly Date {  get; set; }
        public string Time { get; set; }
        public int SubCategoryId { get; set; }
        public int? ServiceProviderId { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal PlatformFee { get; set; }
        public decimal SubTotal { get; set; }
        public int OrderStatusID { get; set; }

    }
}
