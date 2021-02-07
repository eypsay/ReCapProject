using Business.Abstract;
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
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int customerId)
        {
            return _customerDal.Get(cus => cus.CustomerId == customerId);
            
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }
    }
}
