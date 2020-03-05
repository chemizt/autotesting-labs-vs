using System;

namespace ArrayProcessForm.Modules
{
    static class DigitCountCalculator
    {
        public static int Calculate(string strNumber)
        {
            return Calculate(Int32.Parse(strNumber));
        }

        public static int Calculate(int number)
        {
            int result = 0;

            while (number > 0)
            {
                result++;
                number /= 10;
            }

            return result;
        }
    }
}
