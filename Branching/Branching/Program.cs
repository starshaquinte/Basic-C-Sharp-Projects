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
            else if (packageweight < 50)

            {       Console.WriteLine("Please enter the package width:");
            Console.ReadLine();

            Console.WriteLine("Please enter the package height:");
            Console.ReadLine();

            Console.WriteLine("Please enter the package length:");
            Console.ReadLine();

            int dimension = Convert.ToInt32(Console.ReadLine());
            }
            else if (dimension > 50)

                Console.WriteLine("Package too big to be shipped via Package Express.");

            int result = (height * width * length) * weight;

            Console.WriteLine(result / 100);

            Console.WriteLine("Your estimated total for shipping this package is: " + result / 100);

            Console.WriteLine("Thank you!");
            Console.ReadLine();









        }
    }
}
