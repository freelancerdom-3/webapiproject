using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.UserCartMapping
{
    public class UserCartMappingModel
    {
        [Key]
        public int MappingId { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }

    }
}

