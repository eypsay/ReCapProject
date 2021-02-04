using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            _iCarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }
        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
        public List<Car> GetAll()
        {
           return  _iCarDal.GetAll();   
        }

        public List<Car> GetAllBrandId(int id)
        {
            return _iCarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _iCarDal.GetAll(c => c.DailyPrice <= max && c.DailyPrice >= min);        }

        public Car Get(int carId)
        {
            return _iCarDal.Get(c => c.CarId==carId);
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }
    }
}
