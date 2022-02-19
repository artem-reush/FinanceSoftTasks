using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_CountOfEntries
{
    public static class StringStats
    {
        //Самая асимптотически быстрая реализация, пришедшая мне в голову.
        //По моим посчётам, работает за время того же порядка, как у используемой сортировки.
        public static string GetNumberOfEntries(string str)
        {
            if(str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            Dictionary<char, int> dic = new Dictionary<char, int>();
            char[] array = str.ToLower().ToCharArray();
            //Сортируем строку.
            Array.Sort(array);
            //Линейно проходим по ней, считая количество повторяющихся символов.
            for(int i = 0; i < array.Length; i++)
            {
                dic.Add(array[i], 1);
                for(int j = i; j < array.Length - 1 && array[j] == array[j + 1]; j++, i++)
                {
                    dic[array[j]]++;
                }
            }
            return DictionaryToString(dic);
        }

        private static string DictionaryToString(Dictionary<char, int> dic)
        {
            IEnumerable<string> records = dic.Select(keyValuePair => $"'{keyValuePair.Key}':{keyValuePair.Value}");
            return String.Join(", ", records);
        }
    }
}
