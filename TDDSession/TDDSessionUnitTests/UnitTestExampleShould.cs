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

        [Test]
        public void ReturnTrue()
        {
            var expected = true;
            var actual = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
