using MediatR;
using TravelPlan.Application.ViewModels;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserViewModel>
    {
        private readonly IUserRepository _userRepository;
        public LoginUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<LoginUserViewModel> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
             var user = await _userRepository.GetUserByEmailAndPasswordAsync(request.Email, request.Password);
            if (user == null) return null;
            return new LoginUserViewModel(user.Email, "Token");
        }
    }
}
