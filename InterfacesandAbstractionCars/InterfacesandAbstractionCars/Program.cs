using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesandAbstractionCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICar tesla = new Tesla(100, "S", "WHITE");
            ICar seat = new Seat("Ibiza", "Black");

            tesla.Start();
            tesla.Stop();
            
            Console.WriteLine(tesla.ToString());
            Console.WriteLine();
            seat.Start();
            seat.Stop();

        }
    }
}
