using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class MathOperation : IMathOperation
    {
        public double AddTwoNumber(double first, double second)
        {
            return first + second;
        }

        public double DivNumber(double first, double second)
        {
            return first / second;
        }
    }
}
