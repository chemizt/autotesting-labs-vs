using System;

namespace ArrayProcessForm.Modules
{
    static class DigitAverageCalculator
    {
        public static float Calculate(string strNumber)
        {
            return Calculate(Int32.Parse(strNumber));
        }
        
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
