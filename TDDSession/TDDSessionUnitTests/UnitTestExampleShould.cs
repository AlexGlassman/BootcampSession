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
    public class UnitTestExampleShould
    {
        private Example example;

        [SetUp]
        public void SetUp()
        {
           example = new Example();
        }

        [Test]
        public void ReturnTrue()
        {
            var expected = true;
            var actual = example.ReturnTrue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddInt()
        {
            var expected = 2;
            List <int> intList = new List<int>() {1, 1};
            var actual = example.AddInts(intList);
            Assert.AreEqual(expected,actual);
        }
    }
}
