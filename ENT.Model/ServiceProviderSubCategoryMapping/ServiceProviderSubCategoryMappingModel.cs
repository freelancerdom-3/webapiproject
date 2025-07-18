using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.ServiceProviderSubCategoryMapping
{
    public class ServiceProviderSubCategoryMappingModel
    {
        [Key]
        public int MappingId { get; set; }
        public int UserId { get; set; }
        public int SubCategoryId { get; set; }
    }
}
