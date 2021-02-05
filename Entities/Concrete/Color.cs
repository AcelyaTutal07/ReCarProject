using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public  class Color:IEntity
    {
        public string ColarName { get; set; }
        public int ColarId { get; set; }


    }
}
