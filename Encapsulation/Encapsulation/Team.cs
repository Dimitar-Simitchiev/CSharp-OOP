using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Team
    {

        public string Name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;  
        public List<Person> FirstTeam { get; set; }
        public List<Person> ReserveTeam { get; set; }
        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();

        }
        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }

        }
        public string ResultTeam()
        {
            return $"First team has  {this.firstTeam.Count} players.Reserve team has {this.reserveTeam.Count} players. ";
        {
            
        }
    }

    }
}
