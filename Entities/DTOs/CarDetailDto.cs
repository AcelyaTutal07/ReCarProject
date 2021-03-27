using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        
   
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string Descriptions { get; set; }
        public int DailyPrice { get; set; }
        public int  ModelYear { get; set; }


    }
}
