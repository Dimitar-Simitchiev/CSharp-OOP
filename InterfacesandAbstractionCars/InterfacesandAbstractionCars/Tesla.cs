using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesandAbstractionCars
{
    internal class Tesla : IElectricCar
    {
        int battery;
        string color;
        string model;
        public Tesla(int battery, string model, string color)
        {
            Battery = battery;
            Model = model;
            Color = color;
        }
    
        public int Battery { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Start()
        {
            Console.WriteLine("Engine Start Tesla ");
        }

        public void Stop()
        {
            Console.WriteLine("Engine Stop Tesla");

        }
        public override string ToString()
        {
            return Battery + " " + Model + " " + Color;
        }
    }
}