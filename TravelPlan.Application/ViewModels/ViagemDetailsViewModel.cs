using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Application.ViewModels
{
    public class ViagemDetailsViewModel
    {
        public ViagemDetailsViewModel(string destiny, string description, int departure, int arrival, int dayBudget, decimal amountSaved, decimal amountWithdrawn)
        {
            Destiny = destiny;
            Description = description;
            Departure = departure;
            Arrival = arrival;
            DayBudget = dayBudget;
            AmountSaved = amountSaved;
            AmountWithdrawn = amountWithdrawn;
        }

        public string Destiny { get; private set; }
        public string Description { get; private set; }
        public int Departure { get; private set; }
        public int Arrival { get; private set; }
        public int DayBudget { get; private set; }
        public decimal AmountSaved { get; private set; }
        public decimal AmountWithdrawn { get; private set; }
    }
}
