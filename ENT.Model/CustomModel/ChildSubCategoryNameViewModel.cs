using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    [Keyless]
    public class ChildSubCategoryNameViewModel
    {
        public int ChildSubCategoryId { get; set; }
        public string ChildSubCategoryName { get; set; }
        public string ChildSubCategoryImageName { get; set; }
    }
}
