using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.ImageNames
{
    public class ImageNameModel
    {
        [Key]
        public int ImageNameId { get; set; }

        public int CategorizedTypeId { get; set; }

        public string CategorizedTypeName { get; set; }

        public string ImageName { get; set; }
    }
}
