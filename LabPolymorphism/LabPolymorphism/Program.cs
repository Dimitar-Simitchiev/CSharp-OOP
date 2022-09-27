using System;
using System.Collections.Generic;
using System.Text;

namespace LabPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());



        }
    }
}
