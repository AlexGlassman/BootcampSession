using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Example
    {
        public bool ReturnTrue()
        {
            return false;
        }

        public int ReturnFive()
        {
            return 6;
        }

        public int AddInts(List<int> intList)
        {
            int total = 0;
            foreach (var number in intList)
            {
                total = total + number;
            }
            return total;
        }

        public string 
    }
}
