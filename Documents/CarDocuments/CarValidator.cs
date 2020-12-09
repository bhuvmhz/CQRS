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
            RuleFor(_ => _.PlateNo.Length).InclusiveBetween(3, 6).WithSeverity(Severity.Warning);
        }
    }
}
