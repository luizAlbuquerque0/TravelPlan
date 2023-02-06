using FluentValidation;
using TravelPlan.Application.Commands.UpdateAtividade;

namespace TravelPlan.Application.Validators
{
    public class UpdateAtividadeCommandValidator : AbstractValidator<UpdateAtividadeCommand>
    {
        public UpdateAtividadeCommandValidator()
        {
            RuleFor(v => v.Description)
                .MaximumLength(100)
                .WithMessage("O tamanho maximo da descrição é de 100 caracteres");

            RuleFor(v => v.IdViagem)
                .NotEmpty()
                .NotNull()
                .WithMessage("O id da viagem é obrigatorio");

            RuleFor(v => v.IdAtividade)
                .NotEmpty()
                .NotNull()
                .WithMessage("O id da ativiade é obrigatorio");
        }
    }
}
