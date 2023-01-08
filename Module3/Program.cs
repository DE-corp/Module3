using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Дмитрий";
            byte MyAge = 31;
            bool HaveIApet = false;
            double MyShoeSize = 44.5;

            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine("Мне " + MyAge);
            Console.WriteLine("У меня есть домашнее животное? " + HaveIApet);
            Console.WriteLine("Мой размер обуви " + MyShoeSize);

            Console.ReadKey();
        }
    }
}
