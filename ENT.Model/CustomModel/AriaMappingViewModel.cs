using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    [Keyless]
    public class AriaMappingViewModel
    {
        public int UserId { get; set; }
        public List<int> AriaListID { get; set; }
    }
}
