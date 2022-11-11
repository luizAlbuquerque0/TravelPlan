using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Core.Entities
{
    public class Atividade : BaseEntity
    {
        public Atividade(string description, int startTime, int endtime, int date, int idViagem)
        {
            Description = description;
            StartTime = startTime;
            Endtime = endtime;
            Date = date;
            IdViagem = idViagem;
        }

        public string Description { get; private set; }
        public int StartTime { get; private set; }
        public int Endtime { get; private set; }
        public int Date { get; private set; }
        public int IdViagem { get; private set; }
        public Viagem Viagem { get; private set; }

        public void ChandeDescription(string description)
        {
            Description = description;
        }
    }
}
