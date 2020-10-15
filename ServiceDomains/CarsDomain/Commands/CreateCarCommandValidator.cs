using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using FluentValidation;

namespace CarsScenarios.CarsDomain.Commands
{
    public class CreateCarCommandValidator: AbstractValidator<CreateCarCommandHandler>
    {
        public CreateCarCommandValidator()
        {

        }
    }
}
