using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSessionUnitTests
{
    [TestFixture]
    public class UnitTestExampleShould
    {

        [SetUp]
        public void SetUp()
        {
            //Gets called before tests are called. Like a constructor.
           // UnitTestExample unitTestExample;
        }

        [Test]
        public void ReturnTrue()
        {
            var expected = true;
            var actual = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
