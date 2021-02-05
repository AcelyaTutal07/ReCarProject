using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
     class CarManager: CarManagerBase : ICarService
    {
        ICarDal _ıcardal;

        public CarManager(ICarDal ıcardal)
        {
            _ıcardal = ıcardal;
        }

    public List<Car> GetAll()
        {
            return _ıcardal.GetAll();
        }
        public List<Car> GetByBrandId(int brandId); 
        {
           return _carDal.GetByBrandId(brandId);
    }
}
