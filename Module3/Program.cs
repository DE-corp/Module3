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
            DayOfWeek FavoriteDay = DayOfWeek.Sunday; ;
            
            Console.WriteLine($"My favorite day is {FavoriteDay}");
            Console.ReadKey();
        }
        
    }
}
