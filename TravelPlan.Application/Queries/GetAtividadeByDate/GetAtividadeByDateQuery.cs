using MediatR;
using TravelPlan.Application.ViewModels;

namespace TravelPlan.Application.Queries.GetAtividadeByDate
{
    public class GetAtividadeByDateQuery : IRequest<List<AtividadeViewModel>>
    {
        public GetAtividadeByDateQuery(int idViagem, int date)
        {
            IdViagem = idViagem;
            Date = date;
        }

        public int IdViagem { get; private set; }
        public int Date { get; private set; }
    }
}
