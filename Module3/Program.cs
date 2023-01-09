using System;

namespace Module3
{
    class Program
    {
        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        static void Main(string[] args)
        {
            Semaphore SemaphoreStage = Semaphore.Green; ;
            
            Console.WriteLine($"Semaphore color stage is {SemaphoreStage}");
            Console.ReadKey();
        }
        
    }
}
