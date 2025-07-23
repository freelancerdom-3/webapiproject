using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    public class ConfirmedOrderViewModel
    {
        public OrderDetailsViewModel OrderDetails { get; set; }
        public List<ServiceQuantityViewModel> ServicesList { get; set; }
    }
}
