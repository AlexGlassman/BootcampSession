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
        public void GetTrue()
        {
            var expected = true;
            var actual = exercise1.GetTrue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetNum()
        {
            var expected = 5;
            var actual = exercise1.GetFive();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThrowException()
        {
            //without generics + if void method
            Assert.Throws(typeof(Exception), exercise1.ThrowException);
            //with generics and method isn't void
            Assert.Throws<Exception>(delegate {exercise1.ThrowException();});
        }
    }
}
