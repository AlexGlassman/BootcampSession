using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Exercise2
    {

        public int Calculate(int num1, int num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }


        public int AddIntList(List<int> intList)
        {
            int total = 0;
            foreach (var number in intList)
            {
                total = total + number;
            }
            return total;
        }
    }
}
