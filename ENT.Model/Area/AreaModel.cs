using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.Area
{
    public class AreaModel
    {
        [Key]
        public int AreaId { get; set; }

        public String AreaName { get; set; }

        public int CityId { get; set; }
    }
}
