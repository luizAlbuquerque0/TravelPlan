﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Application.ViewModels;

namespace TravelPlan.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUserViewModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
