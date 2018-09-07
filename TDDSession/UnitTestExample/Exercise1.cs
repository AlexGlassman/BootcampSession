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

        public int GetFive()
        {
            return 6;
        }

        public int DivideByZero()
        {
            int zero = 0;
            int num = 1 / zero;
            return num;
        }
    }
}
