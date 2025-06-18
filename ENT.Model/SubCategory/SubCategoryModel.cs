using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.SubCategory
{
    public class SubCategoryModel
    {
        [Key]
        public int SubCategoryId { get; set; }
        [Required]
        public string? SubCategoryName { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoreId { get; set; }
        public string? ImageName { get; set; }
    }
}
