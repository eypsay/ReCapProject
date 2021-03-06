﻿using Business.Abstract;
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
   public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            if (brand.Name.Length < 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }

            
            _brandDal.Add(brand);


            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {

            if (brand.Name.Length < 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _brandDal.Delete(brand);

            return new SuccessResult( Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
             }



                return new SuccessDataResult < List < Brand >>(_brandDal.GetAll(),Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<Brand>(Messages.ColorListed);
            }
            return   new SuccessDataResult<Brand>( _brandDal.Get(b => b.BrandId==brandId),Messages.BrandListed);
        }

        public IResult Update(Brand brand)
        {

            if (brand.Name.Length < 2)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _brandDal.Update(brand);

            return new SuccessResult( Messages.BrandUpdated);
        }

       
    }
}
