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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var returndate = _rentalDal.Get(r => r.CarId==rental.CarId);

            if (returndate!=null)
            {
                Console.WriteLine(Messages.RentNameInvalid);
                return new  ErrorResult(Messages.CarNameInvalid);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Rental rental)
        {
            if (rental.Id < 0)
            {
                Console.WriteLine(Messages.RentNameInvalid);
                return new ErrorResult(Messages.RentalDeleted);
            }
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
           
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalDeleted);
        }

        public IDataResult<Rental> GetByCarId(int carId)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }
            //burası rental ablosundaki id(PK) göre getiriyor 
            //return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentId));

            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == carId));   //uradki rentId yi carId olarak kullandım     
        }

        public IDataResult<Rental> GetById(int rentId)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }
           
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentId));
   
                }

        public IResult Update(Rental rental)
        {
            var rentalById = _rentalDal.Get(r => r.CarId == rental.CarId);

            if (rentalById.ReturnDate != null)
            {
                Console.WriteLine(Messages.CarNameInvalid);
                return new ErrorResult(Messages.RentalUpdated);
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
