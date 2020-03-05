using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessForm.Modules
{
    static class MaxDigitFinder
    {
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
