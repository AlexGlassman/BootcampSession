using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Exercise1
    {
        public bool GetTrue()
        {
            return false;
        }

        public int GetNum()
        {
            return 6;
        }

        public void ThrowException()
        {
            throw new Exception("This is an exception!");
        }
    }
}
