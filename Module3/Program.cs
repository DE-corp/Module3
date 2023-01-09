using System;

namespace Module3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введи свое имя: ");
            string Name = Console.ReadLine();
            Console.Write("Сколько лет: ");
            int Age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine($"Тебя зовут {Name}, тебе {Age}");
            Console.ReadKey();
        }
        
    }
}
