using System;

namespace Module3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введи свой возраст: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine($"Твой возраст {age}");
            Console.ReadKey();
        }
        
    }
}
