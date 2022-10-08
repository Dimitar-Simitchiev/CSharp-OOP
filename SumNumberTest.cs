using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnitTesting;

namespace TestUnitTest
{
    [TestFixture]
    public class SumNumberTest
    {
        [Test]
      public void SumOfdigits()
      {
            MathOperstion math = new MathOperstion();
            
            Assert.AreEqual(9, math.Sumnumber(4, 5));
        }
        [Test]
        public void SumOfdigitsNegative()
        {
            MathOperstion math = new MathOperstion();
            
            Assert.AreEqual(-2, math.Sumnumber(-1, -1));
        }
        [Test]
        public void SumOfdigitZero()
        {
            MathOperstion math = new MathOperstion();
            
            Assert.AreEqual(0, math.Sumnumber(0, 0));
        }




    }
}
