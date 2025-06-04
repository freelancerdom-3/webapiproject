using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    [Keyless]
    public class ServiceProviderSubCategoryMappingViewModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string SubCategoryName { get; set; }
    }
}
