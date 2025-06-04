using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.JwtToken
{
    public class JwtTokenModel
    {
        public string jwtToken {  get; set; }

        public DateTime expiryTime { get; set; }
    }
}
