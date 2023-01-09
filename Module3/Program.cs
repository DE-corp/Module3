using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            string CompName = "Dell";
            Console.WriteLine($"Привет человек! Меня зовут {CompName}");
            Console.Write("А как зовут тебя? ");
            string MyName = Console.ReadLine();
            Console.Write("Рад знакомству {0}", MyName);

            Console.ReadKey();
        }
        
    }
}
