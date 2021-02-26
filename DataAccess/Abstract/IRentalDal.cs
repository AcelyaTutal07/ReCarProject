using Core.DataAccess;
using Core.Entities.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
       List<RentalDetailDto> GetRentalDetails();
    }
}
