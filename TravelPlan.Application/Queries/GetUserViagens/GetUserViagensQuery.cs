using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Application.ViewModels;

namespace TravelPlan.Application.Queries.GetUserViagens
{
    public class GetUserViagensQuery : IRequest<List<ViagensViewModel>>
    {
        public GetUserViagensQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
