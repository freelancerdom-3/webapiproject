﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.Services
{
    public class ServicesModel
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? SubCategoryId { get; set; }
        public decimal Price { get; set; }
        public string TimeTaken { get; set; }
        public int MainSubCategoryId { get; set; }
    }
}
