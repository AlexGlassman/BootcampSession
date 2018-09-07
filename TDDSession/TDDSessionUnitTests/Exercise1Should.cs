using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample;

namespace TDDSessionUnitTests
{
    [TestFixture]
    public class Exercise1Should
    {
        private Exercise1 exercise1;

        [SetUp]
        public void SetUp()
        {
           exercise1 = new Exercise1();
        }

        [Test]
        public void ReturnTrue()
        {
            var expected = true;
            var actual = exercise1.GetTrue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnNum()
        {
            var expected = 5;
            var actual = exercise1.GetFive();
            Assert.AreEqual(expected, actual);
        }
    }
}
