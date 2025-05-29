using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.City
{
    public class CityModel
    {
        [Key]
        public int CityId {  get; set; }
        public string? CityName { get; set; }
        public int StateId {  get; set; }
    }
}
