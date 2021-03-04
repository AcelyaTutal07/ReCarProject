using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult();
     
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
          
            return new SuccessDataResult<List<Brand>>(Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
       
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
        public IResult Update(Brand brand)
        {
            return new SuccessResult(Messages.Updated);
        }

     

        public IDataResult<List<Brand>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(c => c.BrandId == id));
        }
    }

}


