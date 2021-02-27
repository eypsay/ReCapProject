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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            if (color.Name.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);

            }
            _colorDal.Add(color);

            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            if (color.Name.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);

            }
            _colorDal.Delete(color);

            return new SuccessResult(Messages.ColorNameInvalid);
        }

        public IDataResult<List <Color>> GetAll()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(),Messages.ColorListed);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<Color>(Messages.MaintenanceTime);
            }
            
            
                return new SuccessDataResult<Color>( _colorDal.Get(c => c.ColorId == colorId),Messages.ColorListed);
            }

        public IResult Update(Color color)
        {
            if (color.Name.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);

            }
            _colorDal.Update(color);

            return new SuccessResult(Messages.ColorAdded);
        }
    }
}
