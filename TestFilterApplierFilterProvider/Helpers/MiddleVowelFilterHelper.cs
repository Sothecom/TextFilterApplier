using System;
using System.Collections.Generic;
using System.Text;

namespace TextFilterApplierFilterProvider.Helpers
{
    public static class MiddleVowelFilterHelper
    {
        public static string GetMiddleCharacters(string input)
        {
            int inputLength = input.Length;

            if (inputLength < 3)
            {
                return input;
            }

            int index;

            if (inputLength % 2 == 0)
            {
                index = (inputLength / 2)-1;
                return input.Substring(index, 2);
            }
            else
            {
                index = (inputLength / 2);
                return input.Substring(index,1);
            }
        }
    }
}
