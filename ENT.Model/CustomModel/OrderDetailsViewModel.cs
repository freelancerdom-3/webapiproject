﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    [Keyless]
    public class OrderDetailsViewModel
    {
        public int OrderID { get; set; }
        public DateOnly Date { get; set; }
        public string Time { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal PlatformFee { get; set; }
        public decimal SubTotal { get; set; }
        public string OrderStatusName { get; set; }
    }
}
