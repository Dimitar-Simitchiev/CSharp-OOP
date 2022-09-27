using System;
using System.Collections.Generic;
using System.Text;

namespace LabPolymorphism
{
    internal class MathOperations
    {

        public void Add(int x ,int y)
        {
            Console.WriteLine( x + y);
        }
        public void Add(decimal x, decimal z,decimal y)
        {
            Console.WriteLine(z+x+y);
        }
        public void Add(double x, double y,double z)
        {
            Console.WriteLine(z + x + y);
        }
    }
}
