using System;
using System.Collections.Generic;
using System.Text;

namespace _1_StringReverce
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] array = str.ToCharArray();
            int i = 0, j = array.Length - 1;
            while (i < j)
            {
                char _tmp = array[i];
                array[i] = array[j];
                array[j] = _tmp;
                i++;
                j--;
            }
            return new string(array);
        }
    }
}
