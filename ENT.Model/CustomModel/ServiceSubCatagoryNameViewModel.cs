using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    public class ServiceSubCatagoryNameViewModel
    {
        [Key]
        public string SubCategoryName { get; set; }
        public string ServiceName { get; set; }
    }
}
