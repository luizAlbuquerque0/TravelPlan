using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Core.Entities
{
    public class Viagem : BaseEntity
    {
        public Viagem(string description, string destiny, int arrival, int departure, int idUser)
        {
            Description = description;
            Destiny = destiny;
            Arrival = arrival;
            Departure = departure;
            AmountWithdrawn = 0;
            AmountSaved = 0;
            Atividades = new List<Atividade>();
            IdUser = idUser;
        }

        public string Description { get; private set; }
        public string Destiny { get; private set; }
        public int Arrival { get; private set; }
        public int Departure { get; private set; }
        public int? DayBudget { get; private set; }
        public decimal AmountSaved { get; set; }
        public decimal AmountWithdrawn { get; set; }
        public List<Atividade> Atividades { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; set; }

        public void AddDayBudget(int dayBudget)
        {
            DayBudget = dayBudget;
        }


    }
}
