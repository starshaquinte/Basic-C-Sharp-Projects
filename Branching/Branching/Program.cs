using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int packageweight = Convert.ToInt32(Console.ReadLine());

            if (packageweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else 
            {
            Console.WriteLine("Please enter the package width:");
             int packageheight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
             int packagewidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
             int packagelength = Convert.ToInt32(Console.ReadLine());

                int dimension = Convert.ToInt32(Console.ReadLine());
            }
            if dimension (packageheight * packagewidth * packagelength > 50)

            {
             Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else Console.WriteLine(result / 100);

            Console.WriteLine("Your estimated total for shipping this package is: " + result / 100);

            Console.WriteLine("Thank you!");
            Console.ReadLine();









        }
    }
}
