﻿using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyName { get; set; }
        public string Descriptions { get; set; }
        public decimal DailyPrice { get; set; }
        public short ModelYear { get; set; }


    }
}