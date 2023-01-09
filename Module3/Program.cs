using System;

namespace Module3
{
    class Program
    {
        enum DaysofWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.Write("Введи свое имя: ");
            var Name = Console.ReadLine();
            Console.Write("Сколько лет: ");
            var Age = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("Введи полную дату рождения: ");
            var BirthDate = Console.ReadLine();
            Console.Write("Какой по счету день недели твой любимый?: ");
            var FavoriteWeekDay = (DaysofWeek)int.Parse(Console.ReadLine());
            Console.WriteLine($"\n\nАНКЕТА ПОЛЬЗОВАТЕЛЯ {Name.ToUpper()}\n\nПроверь все ли данные корректно введены!!!\n");
            Console.WriteLine($"Имя: {Name}\nДата рождения: {BirthDate}\nПолных лет: {Age}\nЛюбимый день недели: {FavoriteWeekDay}");
            Console.ReadKey();
        }
        
    }
}
