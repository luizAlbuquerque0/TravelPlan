using FluentValidation;
using System.Text.RegularExpressions;
using TravelPlan.Application.Commands.CreateUser;

namespace TravelPlan.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(u => u.Email)
               .EmailAddress()
               .WithMessage("E-mail não válido");

            RuleFor(u => u.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("O nome é obrigatorio");

            RuleFor(u => u.Password)
                .Must(validPassword)
                .WithMessage("Senha deve conter pelo menos 8 caracteres, um número, uma letra maiúscula, um número e um caracter especial");
        }

        public bool validPassword(string password)
        {
            var regex = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");

            return regex.IsMatch(password);
        }
    }
}
