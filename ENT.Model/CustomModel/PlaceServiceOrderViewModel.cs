﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT.Model.CustomModel
{
    public class PlaceServiceOrderViewModel
    {
        public int EndUserId { get; set; }
        public DateOnly Date {  get; set; }
        public string Time { get; set; }
        public int SubCategoryId { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal PlatformFee { get; set; }
        public decimal SubTotal { get; set; }
        public required List<ServiceQuantityViewModel> ServicesList { get; set; }
    }
}
