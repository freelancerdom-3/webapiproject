using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    [Keyless]
    public class RegionNameViewModel
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
    }
}
