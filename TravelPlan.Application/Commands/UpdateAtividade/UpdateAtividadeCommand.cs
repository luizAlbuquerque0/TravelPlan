using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Application.ViewModels;

namespace TravelPlan.Application.Commands.UpdateAtividade
{
    public class UpdateAtividadeCommand : IRequest<Unit>
    {
        public int IdViagem { get; set; }
        public int IdAtividade { get; set; }
        public string Description { get; set; }
    }
}

