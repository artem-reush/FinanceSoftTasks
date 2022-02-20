using System;
using System.Collections.Generic;
using System.Text;

namespace _1_StringReverce
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length == 0)
            {
                return "";
            }
            if(str.Length == 1)
            {
                return new string(str[0], 1);
            }
            char[] array = str.CustomToCharArray();
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
        //Аналог ToCharArray() из System.String
        public static char[] CustomToCharArray(this string str)
        {
            if(str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if(str.Length == 0)
            {
                return new char[0];
            }
            char[] array = new char[str.Length];
            int i = 0;
            int j = str.Length;
            while (i < j)
            {
                array[i] = str[i];
                i++;
            }
            return array;
        }
    }
}
