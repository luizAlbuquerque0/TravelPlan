using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Application.ViewModels
{
    public class ViagensViewModel
    {
        public ViagensViewModel(int travelId, string destiny, string description, int departure)
        {
            TravelId = travelId;
            Destiny = destiny;
            Description = description;
            Departure = departure;
        }

        public int TravelId { get; private set; }
        public string Destiny { get; private set; }
        public string Description { get; private set; }
        public int Departure { get; private set; }

    }
}
