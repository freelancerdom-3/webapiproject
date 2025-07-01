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
    public class SubCategoryImageNameViewModel
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryImageName { get; set; }
    }
}
