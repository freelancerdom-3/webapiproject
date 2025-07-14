using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    public class CartServiceQuantityViewModel
    {
        public int CartId { get; set; }
        public List<ServiceQuantityViewModel> ServiceQuantityList { get; set; }
    }
}
