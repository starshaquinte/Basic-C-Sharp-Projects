using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer obj = new Integer();

            Console.WriteLine("Please enter a number. ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(obj.addition(userInput));
            

            Console.WriteLine(obj.subtraction(userInput));
            

            Console.WriteLine(obj.multiplication(userInput));
            Console.ReadLine();

        }

        
        
    }
}
