namespace _1_StringReverce
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
            foreach (string str in sentences)
            {
                System.Console.WriteLine("\"{0}\" - \"{1}\"", str, str.Reverse());
            }

        }
    }
}
