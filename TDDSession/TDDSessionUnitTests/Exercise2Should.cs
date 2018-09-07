using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample;

namespace TDDSessionUnitTests
{
    public class Exercise2Should
    {
        private Exercise2 ex2;

        [SetUp]
        public void SetUp()
        {
            ex2 = new Exercise2();
        }

        [TestCase(5,5,"+")]
        [TestCase(-4, 1000, "+")]
        [TestCase(0.1, 4, "+")]
        public void Add(int num1, int num2, string op)
        {
            var expected = num1 + num2;
            var actual = ex2.Calculate(num1, num2, op);
            Assert.AreEqual(expected, actual);
        }
    }
}
