using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    public class SubCategoryServiceQuantityViewModel
    {
        public SubCategoryImageNameViewModel SubCategoryImageNameData { get; set; }

        public List<ServiceQuantityViewModel> serviceQuantityList { get; set; }
    }
}
