using System;

namespace Module3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введи свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Твой возраст {age}");
            Console.ReadKey();
        }
        
    }
}
