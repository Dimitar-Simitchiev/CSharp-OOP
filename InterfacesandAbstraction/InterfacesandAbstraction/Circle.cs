using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesandAbstraction
{
    internal class Circle : IDrawable
    {
        private int Radius;
        public Circle(int radius)
        {
            Radius = radius;
        }
        public void Draw()
        {
            for (int i = 0; i < Radius*2; i++)
            {
                for (int j = 0; j < Radius*2; j++)
                {
                    var distance = Math.Sqrt((Radius - i) * (Radius - i) + (Radius - j) * (Radius - j));
                    if (Math.Ceiling(distance)==Radius-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                } Console.WriteLine();
            }
            
        }
    }
}
