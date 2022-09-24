using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesandAbstraction
{
    internal class Rectangle : IDrawable
    {
        private int Hight { get; set; }
        private int Wight { get; set; }
        public Rectangle(int hight,int width)
        {
            Wight = width;
            Hight = hight;
        }
        public void Draw()
        {
            Console.WriteLine( new string('*', Hight));
            for (int i = 0; i < Wight-2; i++)
            {
                Console.WriteLine('*'+new string(' ',Hight-2)+'*');
               

            }
            Console.WriteLine(new string('*', Hight));

        }
    }
}
