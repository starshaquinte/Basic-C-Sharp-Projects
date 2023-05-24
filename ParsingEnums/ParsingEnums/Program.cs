using System;

namespace ParsingEnums
{
    class Program
    {
       
        public enum DaysOfTheWeek //created an enum for the days of the week 
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main()
        {
            Console.WriteLine("Enter the current day of the week:"); //promting user to enter current day
            string input = Console.ReadLine(); //printing their answer to the screen
            try //try block
            {
                DaysOfTheWeek currentday = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine(currentday); //parsed the enum
            }
            catch //catch block
            {
                Console.WriteLine("Please enter an actual day of the week."); // if error occurs catch block will execute
            }
            Console.ReadLine();
        }
    }
}
