﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
