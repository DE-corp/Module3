using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Дмитрий";
            Console.WriteLine("Привет, мир");
            Console.WriteLine();

            Console.WriteLine("Меня зовут {0}", MyName);
            Console.WriteLine();

            Console.WriteLine("Меня зовут {0}", "Дима");
            Console.WriteLine();

            byte age = 31;
            byte weight = 250;
            Console.WriteLine("Возраст {0} \nВес {1}", age, weight);
            Console.WriteLine();

            Console.WriteLine($"Имя - {MyName}. Возраст - {age}. Вес - {weight}");

            Console.ReadKey();
        }
        
    }
}
