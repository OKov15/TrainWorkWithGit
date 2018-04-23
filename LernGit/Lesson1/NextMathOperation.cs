using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class NextMathOperation
    {
        public double DifferentBetweenDivAndAdd(double first, double second)
        {
            MathOperation mathOperation = new MathOperation();
            return mathOperation.DivNumber(first, second) - mathOperation.AddTwoNumber(first, second);
        }
    }
}
