using System;
using System.Collections.Generic;
using System.Text;

namespace _2_IsPalindrome
{
    public static class StringExtentions
    {
        public static bool IsPalindrome(this string str)
        {
            if(str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if(str.Length < 2)
            {
                return true;
            }
            string lowerStr = str.DeleteNotLetters().ToLower();
            //При таком подходе достаточно обойти лишь буквы с индексами 0...length/2-1. Деление целочисленное.
            int endIndex = lowerStr.Length / 2 - 1;
            for (int i = 0, j = lowerStr.Length - 1; i <= endIndex; i++, j--)
            {
                if(lowerStr[i] != lowerStr[j])
                {
                    return false;
                }
            }
            return true;
        }

        private static string DeleteNotLetters(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            const char russianUppercaseA = 'А';
            const char russianLowercaseA = 'а';
            const char englishUppercaseA = 'A';
            const char englishLowercaseA = 'a';
            //Длина новой строки не более длины исходной.
            StringBuilder sb = new StringBuilder(str.Length);
            foreach(char sign in str)
            {
                bool isRussianLetter = (sign >= russianUppercaseA && sign <= 'Я') || 
                    (sign >= russianLowercaseA && sign <= 'я');
                bool isEnglishLetter = (sign >= englishUppercaseA && sign <= 'Z') ||
                    (sign >= englishLowercaseA && sign <= 'z');
                if (isRussianLetter || isEnglishLetter)
                {
                    sb.Append(sign);
                }
            }
            return sb.ToString();
        }
    }
}
