using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class RandomList : List<int>
    {
        List<int> list = new List<int>();
        Random random = new Random();   
        public void RandomAdd(int index)
        {
            var result = random.Next(0, index);
            list.Add(result);


        }
        public void Result()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}