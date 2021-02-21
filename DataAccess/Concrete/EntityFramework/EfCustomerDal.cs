using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarContext>, ICustomerDal
    {


        public List<UserCustomerDto> GetUserDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from u in context.Users
                             join cus in context.Customers on u.Id equals cus.UserId
                             select new UserCustomerDto
                             {
                                 UserId = cus.UserId,
                                 FirstName = u.FirstName,
                                 CompanyName = cus.CompanyName,
                                 Email = u.Email,
                             };
                return result.ToList();

            }
        }

    }
}
