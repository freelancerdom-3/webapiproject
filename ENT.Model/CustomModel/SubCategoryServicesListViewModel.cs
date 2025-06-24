using ENT.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    public class SubCategoryServicesListViewModel
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public List<ChildSubCategoryNameViewModel> ChildSubCategoriesList { get; set; }
        public List<ChildSubCategoryServicesViewModel> ChildSubCategoryServicesList { get; set; }
    }
}
