using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime currentTime = DateTime.Now()
           Console.WriteLine("Current date and time: " + currentTime);
           Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = currentTime.AddHours(num);
            Console.WriteLine("It will be " + futureTime in num hours.);

        }
    }
}
