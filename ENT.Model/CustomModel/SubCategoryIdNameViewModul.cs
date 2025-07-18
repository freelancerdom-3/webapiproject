using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    [Keyless]
    public class SubCategoryIdNameViewModul
    {
        public int SubCategoryId { get; set; }

        public string? SubCategoryName { get; set; }
    }
}
