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
    public class TestNegative
    {
        [Test]
        public void testNegative()
        {
            MathOperstion math = new MathOperstion();
            Assert.True(math.NegativeNumber(-1));
        }
        [Test]
        public void testNegativeZero()
        {
            MathOperstion math = new MathOperstion();
            Assert.Throws<Exception>(() => math.NegativeNumber(0));
        }
    }
}
