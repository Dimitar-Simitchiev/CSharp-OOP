using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            Team team = new Team("SoftUni");

            

            for (int i = 0; i < lines; i++)
            {
                string []cmdArgs = Console.ReadLine().Split();
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
                
            }
            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }


            Console.WriteLine(team.ResultTeam());


        }
    }
}
