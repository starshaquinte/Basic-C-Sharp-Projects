using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            //First line of the program the daily report

            Console.WriteLine("What is your name?");
            string yourname = Console.ReadLine();
            Console.WriteLine("your name is: " + yourname);
            Console.ReadLine();
            //First question using string data type to ask student's name

            Console.WriteLine("What course are you on?");
            string currentcourse = Console.ReadLine();
            Console.WriteLine("You are on the: " + currentcourse);
            //Second question using string data type to find out currect course

            Console.WriteLine("What page number?");
            int page = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Your page number is: " + page);
            //Third question using int data type to find out page number

            Console.WriteLine("Do you need help with anything");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            //Fourth question using boolean data typr to find out if help is needed

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            //Asking user for specific phrase answer

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //Asking user for specific phrase answer

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied for  " + hours);
            //Last question using integer data type to find out the amount of hurs studied

            Console.WriteLine
            Printf("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!");
            //End of program



        }
    }
}
