using MediatR;
using TravelPlan.Application.ViewModels;

namespace TravelPlan.Application.Queries.GetViagemById
{
    public class GetViagemByIdQuery : IRequest<ViagemDetailsViewModel>
    {
        public GetViagemByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
