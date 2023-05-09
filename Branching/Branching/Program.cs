using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:"); //user is prompted to enter package weight
            int packageWeight = Convert.ToInt32(Console.ReadLine());  //int data type to store package weight

            if (packageWeight > 50) //if condition statement, if package weight is greater than 50 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //result if package weight is over 50
            }
            else //else statement 
            {
                Console.WriteLine("Please enter the package width:"); //user enters package height
                int packageHeight = Convert.ToInt32(Console.ReadLine()); //int data type to store package height

                Console.WriteLine("Please enter the package height:"); //user enters package width
                int packageWidth = Convert.ToInt32(Console.ReadLine()); //int data type to store package width

                Console.WriteLine("Please enter the package length:"); //user enters package length
                int packageLength = Convert.ToInt32(Console.ReadLine()); //int data type to store package length

                int dimension = packageHeight + packageWidth + packageLength; //defines dimension 
                if (dimension < 50)  
                {

                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int result = (packageHeight * packageWidth * packageLength * packageWeight) / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + result / 100);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();

                }
            }
        }
    }
}
