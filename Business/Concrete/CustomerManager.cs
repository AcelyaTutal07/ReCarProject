using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public  class CustomerManager :ICustomerService
    {
        ICustomerDal _customersDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customersDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customersDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Customer customer)
        {
            _customersDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customersDal.GetAll());
        }

        public IDataResult<Customer> GetById(int userid)
        {
            return new SuccessDataResult<Customer>(_customersDal.Get(p => p.UserId == userid));
        }

        public IResult Update(Customer customer)
        {
            _customersDal.Update(customer);
            return new SuccessResult(Messages.Updated);

        }
    }
}
