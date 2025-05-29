using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.ServiceAreaMapping
{
    public class ServiceAreaMappingModel
    {
        [Key]
        public int MappingId {  get; set; }

        public int ServiceId { get; set; }

        public int AreaId { get; set; }
    }
}
