using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            Console.WriteLine(age > 15 && hasDUI == false && tickets <= 3);
            
        }
    }
}
