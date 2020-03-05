using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArrayProcessForm.Modules
{
    static class ArrayConverter
    {
        public static List<int> Convert(ListBox.ObjectCollection baseList)
        {
            List<int> result = new List<int>();

            foreach (object number in baseList)
            {
                result.Add(Int32.Parse(number.ToString()));
            }

            return result;
        }
    }
}
