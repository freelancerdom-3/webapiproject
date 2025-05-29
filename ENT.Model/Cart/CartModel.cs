using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.Cart
{
    public class CartModel
    {
        [Key]
        public int CartId { get; set; }
        public decimal Price { get; set; }
    }
}
