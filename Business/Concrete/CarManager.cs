using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Car car)
        {
            //urunu eklemeden once kurallar varsa buraya yazılır
            //add car icin bizim name alanı tabloda yoktu onun icin dec kısmını yazdım
            if (car.Description.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            
            _iCarDal.Add(car);


            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new Result(true, "A  Car Delete.");
        }
        public IResult Update(Car car)
        {
            _iCarDal.Update(car);
            return new Result(true, "A  Car Update.");
        }
        public IDataResult<List<Car>> GetAll()
        {
            //return new DataResult<List<Car>>(  _iCarDal.GetAll(),true,"arabalar listelendi");   
            //yerine
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.DailyPrice <= max && c.DailyPrice >= min));        }

        //////public Car Get(int carId)
        //////{
        //////    return _iCarDal.Get(c => c.CarId==carId);
        //////}

        //public Car Get()
        //{
        //    throw new NotImplementedException();
        //}

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 01)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetails());
        }

        public IDataResult<Car> GetById(int car_Id)
        {
            return new SuccessDataResult<Car>(_iCarDal.Get(c => c.CarId == car_Id));
        }
    }
}
