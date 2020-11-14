using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Documents.CarDocuments
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(_ => _.PlateNo).Equal("LYE801").WithSeverity(Severity.Warning);
        }
    }
}
