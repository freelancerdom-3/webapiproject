using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.ServiceCartMapping
{
    public class ServiceCartMappingModel
    {
        [Key]
        public int MappingId { get; set; }
        public int ServicesId { get; set; }
        public int CartId { get; set; }

    }
}

