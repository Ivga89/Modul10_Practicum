using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICalculator
{
    public class Calculator : ICalculator
    {
        float ICalculator.Addition(float value1, float value2)
        {
            return value1 + value2;
        }
    }
}
