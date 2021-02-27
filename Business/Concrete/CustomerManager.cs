using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class CustomerManager : ICustomerService
    {
        //Bu bussiness katmanı Dataaccess'e bagımlı
        //Bagımlılıgımızı minimize etmek için constructur injection ile yapılır
        //cunku dataaccess katmanı veritabanları mix olablir, depera,oracle gecebilir

        ICustomerDal _customerDal;

        //Asaıgdaki constr icin;ben categoryManager olarak verierişim katmanına bagımlıyım
        //ama zayıf bagımlıgım var Interface uzerinden yani referans uzeriden  bagımlıgım var
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

       

        //Is kodlari buraya yazılacak
        public IDataResult< List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }

                return new SuccessDataResult<List<Customer>>( _customerDal.GetAll(),Messages.CustomerListed);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<Customer>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<Customer>( _customerDal.Get(cus => cus.Id == customerId),Messages.CustomerListed);
            
        }

        public IResult Update(Customer customer)
        {
            if (customer.CustomerName.Length < 2)
            {
                return new ErrorResult(Messages.CustomerNameInvalid);
            }
                _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
            if (customer.CustomerName.Length < 2)
            {
                return new ErrorResult(Messages.CustomerNameInvalid);
            }
                _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            if (customer.CustomerName.Length < 2)
            {
                return new ErrorResult(Messages.CustomerNameInvalid);
            }
                _customerDal.Delete(customer);

            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
