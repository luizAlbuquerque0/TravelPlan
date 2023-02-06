using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Application.Commands.CreateViagem;

namespace TravelPlan.Application.Validators
{
    public class CreateViagemCommandValidator : AbstractValidator<CreateViagemCommand>
    {
        public CreateViagemCommandValidator()
        {
            RuleFor(v => v.Description)
                .MaximumLength(100)
                .WithMessage("Tamanho maximo da descrição é de 100 caracteres");

            RuleFor(v => v.Destiny)
                .NotEmpty()
                .NotNull()
                .WithMessage("O destino é obrigatorio");

            RuleFor(v => v.Arrival)
                .NotEmpty()
                .NotNull()
                .WithMessage("A data da volta é obrigatorio");

            RuleFor(v => v.Departure)
                .NotEmpty()
                .NotNull()
                .WithMessage("A data da ida é obrigatorio");

            RuleFor(v => v.IdUser)
                .NotEmpty()
                .NotNull()
                .WithMessage("O id do usuário é obrigatorio");
        }
    }
}
