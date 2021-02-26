using Business.Abstract;
using Business.Constants;
using Core.Entities.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class RentalsManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalsManager(IRentalDal rentaldal)
        {
            _rentalDal = rentaldal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate != null )
            {
                _rentalDal.Add(rental);
                return new  SuccessResult(Messages.Added);
            }
            return new  ErrorResults("Araba teslim edilmedi! Kiralanamaz.");

        }

        public IResult Delete(Rental rental)
        {
            if (rental.ReturnDate != null) 
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.Deleted);

            }
            return new ErrorResults("Araba teslim edilmedi! Silinemez.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new  SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }


        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentId == id));
        }

        public IDataResult<List<Rental>> GetRentalCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            //İş Koldarı
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

    

        public IResult Update(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.Updated);

            }
            return new ErrorResults("Araba teslim edilmedi! Güncellenemez.");
        }
    }
}
