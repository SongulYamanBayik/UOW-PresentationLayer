using OUW_DAL.Abstract;
using OUW_DAL.UnitOfWork.Abstract;
using OUW_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW_BL.Abstract;

namespace UOW_BL.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IUOWDal _uOWDal;

        public CustomerManager(ICustomerDal customerDal, IUOWDal uOWDal)
        {
            _customerDal = customerDal;
            _uOWDal = uOWDal;
        }

        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _uOWDal.save();
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _uOWDal.save();
        }
    }
}
