using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Calculator.StandardCalculator
{
    public interface IStandardCalculator
    {
        int Add(int number1, int number2);
        int Substract(int number1, int number2);
    }
}
