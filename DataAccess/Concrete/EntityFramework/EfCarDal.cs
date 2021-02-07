﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context=new CarContext ())
            {
                var result = from c in context.Cars
                             join cus in context.Customers on c.CustomerId equals cus.CustomerId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join col in context.Colors on c.ColorId equals col.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = b.Name,
                                 Payment = cus.Payment,
                                 CustomerName = cus.CustomerName,
                                 DailyPrice =c.DailyPrice,
                                 ColorName =col.Name,
                             };
                return result.ToList();
            }

          
        }
    }
}
