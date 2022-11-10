using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Application.ViewModels
{
    public class ViagensViewModel
    {
        public ViagensViewModel(string destiny, string description, int departure)
        {
            Destiny = destiny;
            Description = description;
            Departure = departure;
        }

        public string Destiny { get; private set; }
        public string Description { get; private set; }
        public int Departure { get; private set; }

    }
}
