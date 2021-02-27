using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {

            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);

            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(c => c.BrandId == 1);
            //brand 1 olan araclar icin günlük ücreti 10dan büyük ve esit olamaı

            //patterne uymalı gibi bir kural koymak icin
            RuleFor(c => c.Description).Must(StartWithA).WithMessage("Description A ile baslamalı");//bizim olusturdgumuz methodu da kullanabiliriz
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
