using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    [Author("Mitko")]
    internal class Program
    {
        [Author("Ivan")]
        static void Main(string[] args)
        {
            Console.WriteLine("HI");

        }
    }
    [AttributeUsage(AttributeTargets.Class |AttributeTargets.Method,AllowMultiple =true)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
