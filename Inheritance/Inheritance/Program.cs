using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new RandomList();
            r.RandomAdd(5);
            r.RandomAdd(10);
            r.RandomAdd(100);
            r.Result();
        }
    }
}
