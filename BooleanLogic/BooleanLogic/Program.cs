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
            int tickets = Convert.ToInt32(> 3);

            Console.WriteLine("Qualified?");

            Console.WriteLine("Applicants must be over 15 years old.");
            bool isOver15 = true;
            bool isOver15 = false;

            Console.WriteLine("Applicants must not have any DUI’s.");
            bool hasDUI = true;
            bool hasDUI = false;

            Console.WriteLine("Applicants must not have more than 3 speeding tickets.");
            bool hasMoreThan3Tickets = true;
            bool hasMoreThan3Tickets = false;
            Console.ReadLine();

        }
    }
}
