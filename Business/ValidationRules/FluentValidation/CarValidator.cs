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
            RuleFor(ca => ca.DailyPrice).NotEmpty();
            RuleFor(ca => ca.DailyPrice).GreaterThan(0);
            RuleFor(ca => ca.BrandId).NotEmpty();
            RuleFor(ca => ca.ColorId).NotEmpty();
            RuleFor(ca => ca.ModelYear).NotEmpty();
            RuleFor(ca => ca.Description).NotEmpty();
        }
    }
}
