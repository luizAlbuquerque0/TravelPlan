using FluentValidation;
using TravelPlan.Application.Commands.DeleteTravel;

namespace TravelPlan.Application.Validators
{
    public class DeleteTravelCommandValidator : AbstractValidator<DeleteTravelCommand>
    {
        public DeleteTravelCommandValidator()
        {
            RuleFor(t => t.TravelId)
                .NotNull()
                .NotEmpty()
                .WithMessage("O id da viagem é obrigatorio");
        }
    }
}
