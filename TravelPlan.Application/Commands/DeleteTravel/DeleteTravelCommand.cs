using MediatR;

namespace TravelPlan.Application.Commands.DeleteTravel
{
    public class DeleteTravelCommand : IRequest<Unit>
    {
        public DeleteTravelCommand(int travelId)
        {
            TravelId = travelId;
        }

        public int TravelId { get; private set; }
    }
}
