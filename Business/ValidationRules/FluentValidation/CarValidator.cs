using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public  class CarValidator:AbstractValidator<Car>
    {
        //hangi nesne için validator yazıcaksam bunun içine yazılıyr
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük fiyatı sıfırdan büyük olmalıdır.");
            RuleFor(c => c.Description).MinimumLength(10).WithMessage("Aracın açıklaması en az 10 karakter olmalıdır.");
            RuleFor(c => c.DailyPrice).NotEmpty();
        }
    }

}
