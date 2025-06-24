using ENT.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    //To store pair of child sub-cateogry and services list
    public class ChildSubCategoryServicesViewModel
    {
        public string ChildSubCategoryName { get; set; }

        public List<ServiceNameViewModel> servicesList { get; set; }
    }
}
