using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Core.Entities
{
    public class Atividade : BaseEntity
    {
        public Atividade(string description, int startTime, int endtime, DateTime date)
        {
            Description = description;
            StartTime = startTime;
            Endtime = endtime;
            Date = date;
        }

        public string Description { get; private set; }
        public int StartTime { get; private set; }
        public int Endtime { get; private set; }
        public DateTime Date { get; private set; }
    }
}
