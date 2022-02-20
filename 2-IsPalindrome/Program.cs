using System;

namespace _2_IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = {
                "",
                "а",
                "Аа",
                "Потоп",
                "   Спел    Лепс",
                "А роза упала на лапу Азора",
                "Он - верба, но Она - бревно",
                "Не палиндром",
                "Dogma I am God",
                "Eva, can I see bees in a cave?",
                "Mr. Owl ate my metal worm",
                "No, Mel Gibson is a casino’s big lemon",
                "Is not a palindrome"
            };
            Console.WriteLine("Task2 - IsPalindrome \t Author: Artem Reush");
            Console.WriteLine(new string('-', 50));
            foreach (string str in sentences)
            {
                Console.WriteLine("\"{0}\" {1} является палиндромом", str, str.IsPalindrome()? string.Empty: "НЕ");
            }
        }
    }
}
