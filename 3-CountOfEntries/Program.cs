using System;
using static _3_CountOfEntries.StringStats;

namespace _3_CountOfEntries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = {
                "финанссофт",
                "Финанс софт",
                "Евгений",
                "Четырёхугольник",
                "Lorem Ipsum is simply",
                "Он - верба, но Она - бревно"
            };
            Console.WriteLine("Task3 - CountOfEntries \t Author: Artem Reush");
            Console.WriteLine(new string('-', 50));
            foreach (string str in sentences)
            {
                Console.WriteLine($"\"{str}\" -> {GetNumberOfEntries(str)}");
            }
        }
    }
}
