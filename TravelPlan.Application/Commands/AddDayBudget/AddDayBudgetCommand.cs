using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Application.Commands.AddDayBudget
{
    public class AddDayBudgetCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int budget { get; set; }
    }
}
