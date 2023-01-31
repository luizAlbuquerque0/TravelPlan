using MediatR;

namespace TravelPlan.Application.Commands.CreateViagem
{
    public class CreateViagemCommand : IRequest<int>
    {
        public string Destiny { get; set; }
        public string Description { get; set; }
        public int Departure { get; set; }
        public int Arrival { get; set; }
        public int IdUser { get; set; }
    }
}
