using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesandAbstractionCars
{
    internal class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public void Start()
        {
            Console.WriteLine("Engine Start Seat");
        }

        public void Stop()
        {
            Console.WriteLine("Engine Stop Seat");
        }
    }
}
