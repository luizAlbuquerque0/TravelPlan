using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email)
        {
            Name = name;
            Email = email;
            CreatedAt = DateTime.Now;
            Viagens = new List<Viagem>();
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Viagem> Viagens { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
