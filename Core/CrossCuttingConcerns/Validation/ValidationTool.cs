using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
 public static   class ValidationTool
    {//carvalidator uzerinde F12 basarak oraya gittik amacaı bir Interface yakalamak.Onun implemet ettiği 
        //abstracata gidince IValidator yakaldım ve onu kullanacağım.
        //Cozmek Install package den fleuntvalidaotr cozdum
        //nu methoda entity,DTO hersey egelebilir onun icin object yazdık
        public static void Validate(IValidator validator,object entity )
        {
            var context = new ValidationContext<object>(entity);
         //  CarValidator carValidator = new CarValidator();
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }

    }
}
