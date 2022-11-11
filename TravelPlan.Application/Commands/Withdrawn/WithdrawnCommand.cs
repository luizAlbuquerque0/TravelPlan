using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Application.Commands.Withdrawn
{
    public class WithdrawnCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
