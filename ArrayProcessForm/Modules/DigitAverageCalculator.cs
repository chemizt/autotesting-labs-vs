using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessForm.Modules
{
    static class DigitAverageCalculator
    {
        public static float Calculate(int number)
        {
            float result = 0;
            int digitCount = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
                digitCount++;
            }

            result /= digitCount;

            return result;
        }
    }
}
