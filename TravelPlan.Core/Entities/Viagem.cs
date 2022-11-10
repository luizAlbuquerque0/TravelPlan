using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Core.Entities
{
    public class Viagem : BaseEntity
    {
        public Viagem(string description, string destiny, DateTime arrival, DateTime departure)
        {
            Description = description;
            Destiny = destiny;
            Arrival = arrival;
            Departure = departure;
            AmountWithdrawn = 0;
            AmountSaved = 0;
            Atividades = new List<Atividade>();
        }

        public string Description { get; private set; }
        public string Destiny { get; private set; }
        public DateTime Arrival { get; private set; }
        public DateTime Departure { get; private set; }
        public int? DayBudget { get; private set; }
        public decimal AmountSaved { get; private set; }
        public decimal AmountWithdrawn { get; private set; }
        public List<Atividade> Atividades { get; private set; }

        public void AddDayBudget(int dayBudget)
        {
            DayBudget = dayBudget;
        }


    }
}
