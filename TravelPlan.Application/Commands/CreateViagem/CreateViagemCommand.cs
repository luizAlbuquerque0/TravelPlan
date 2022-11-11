using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Application.ViewModels;

namespace TravelPlan.Application.Commands.CreateViagem
{
    public class CreateViagemCommand : IRequest<ViagemDetailsViewModel>
    {
        public string Destiny { get; set; }
        public string Description { get; set; }
        public int Departure { get; set; }
        public int Arrival { get; set; }
        public int IdUser { get; set; }
    }
}
