using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.Common
{
    public class APIResponseModel
    {
        public string? Message { get; set; }
        public int statusCode { get; set; }
        public Object Data { get; set; }
    }
}
