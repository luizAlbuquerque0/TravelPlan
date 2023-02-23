using MediatR;

namespace TravelPlan.Application.Commands.AddActivitie
{
    public class AddActivitieCommand : IRequest<Unit>
    {
        public int TravelId { get;  set; }
        public string Description { get;  set; }
        public int StatTime { get;  set; }
        public int EndTime { get;  set; }
        public int Date { get;  set; }
    }
}
