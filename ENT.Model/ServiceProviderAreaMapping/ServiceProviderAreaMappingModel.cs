using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.ServiceProviderAreaMapping
{
    public class ServiceProviderAreaMappingModel
    {
        [Key]
        public int MappingId {  get; set; }
        public int UserId { get; set; }
        public int AreaId { get; set; }
    }
}
