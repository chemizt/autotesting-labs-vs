using System;

namespace ArrayProcessForm.Modules
{
    static class MaxDigitFinder
    {
        public static int Find(string strNumber)
        {
            return Find(Int32.Parse(strNumber));
        }

        public static int Find(int number)
        {
            int maxDigit = 0;

            while (number > 0)
            {
                maxDigit = number % 10 > maxDigit ? number % 10 : maxDigit;
                number /= 10;
            }

            return maxDigit;
        }
    }
}
