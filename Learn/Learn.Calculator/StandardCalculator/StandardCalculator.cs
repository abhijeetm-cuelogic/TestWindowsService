using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Calculator.StandardCalculator
{
    public class StandardCalculator : IStandardCalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Substract(int number1, int number2)
        {
            return Math.Abs(number1 - number2);
        }
    }
}
