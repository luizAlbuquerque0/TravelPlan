using MediatR;

namespace TravelPlan.Application.Commands.AddActivitie
{
    public class AddActivitieCommand : IRequest<Unit>
    {
        public AddActivitieCommand(int travelId, string description, int statTime, int endTime, int date)
        {
            TravelId = travelId;
            Description = description;
            StatTime = statTime;
            EndTime = endTime;
            Date = date;
        }

        public int TravelId { get; private set; }
        public string Description { get; private set; }
        public int StatTime { get; private set; }
        public int EndTime { get; private set; }
        public int Date { get; private set; }
    }
}
