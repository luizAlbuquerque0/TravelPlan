using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Application.ViewModels
{
    public class AtividadeViewModel
    {
        public AtividadeViewModel(string descriprion, int startTime, int endTime)
        {
            Descriprion = descriprion;
            StartTime = startTime;
            EndTime = endTime;
        }

        public string Descriprion { get; private set; }
        public int StartTime { get; private set; }
        public int EndTime { get; private set; }
    }
}
