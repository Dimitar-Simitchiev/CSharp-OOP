using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class MathOperstion
    {


        public int Sumnumber(int a,int b)
        {
           
            int sum= a + b;
            return sum;
        }
        public bool NegativeNumber(int n)
        {
            if (n<0)
            {
                return true;
            }
            if (n == 0)
            {
                throw new Exception("Must be number up and down of Zero!");
            }
           
            else
            {
                return false;
            }
        }
    }
}
