using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesandAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable circle = new Circle(5);
            IDrawable rectangle = new Rectangle(5,5);
            rectangle.Draw();
            circle.Draw();  
        }
    }
}
