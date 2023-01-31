﻿using MediatR;
using TravelPlan.Core.Entities;
using TravelPlan.Core.Repositories;
using TravelPlan.Core.Services;

namespace TravelPlan.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        public CreateUserCommandHandler(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var user = new User(request.Name, request.Email, passwordHash);
            await _userRepository.CreateUserAsync(user);
            return user.Id;
        }
    }
}
    