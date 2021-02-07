using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        /*IEntityRepository interfaceni yazdığımız için
         * asaidaki kodları yenisi olan asaidakilerle
         * degistirdik*/
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car> {
        //    new Car { CarId=1,BrandId=1,ColorId =1,ModelYear =1999,
        //    DailyPrice =100,Description="Sedan"},
        //    new Car { CarId=2,BrandId=1,ColorId =2,ModelYear =2020,
        //    DailyPrice =400,Description="Caprio"},
        //    new Car { CarId=3,BrandId=2,ColorId =1,ModelYear =2000,
        //    DailyPrice =200,Description="Hatchback"},
        //    new Car { CarId=4,BrandId=3,ColorId =3,ModelYear =2010,
        //    DailyPrice =300,Description="Spor"},
        //    new Car { CarId=5,BrandId=4,ColorId =5,ModelYear =2019,
        //    DailyPrice =350,Description="Station Wagon"},
        //    };
        //}
        //public void Add(Car car)
        //{
        //    //throw new NotImplementedException();
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    _cars.Remove(_cars.SingleOrDefault(c => c.CarId == car.CarId));
        //}

        //public List<Car> GetAll()
        //{

        //    return _cars;
        //}

        //public List<Car> GetById(int carId)
        //{
        //    //deneme

        //    return  _cars.Where(c => c.CarId== carId).ToList();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.ModelYear = car.ModelYear;
        //    carToUpdate.Description = car.Description;

        //}
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
