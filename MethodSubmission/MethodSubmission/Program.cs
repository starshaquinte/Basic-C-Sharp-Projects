using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Math obj = new Math(); //instantiated class object
            Console.WriteLine("Please enter a number:"); //Ask the user to enter a number 
            int num = Convert.ToInt32(Console.ReadLine()); //the user's answer( takes int the input and assigns it to num)
            try //try block  
            {
                Console.WriteLine("Enter a 2nd number if you want:"); //Give the user an option to enter a 2nd number
                int num2 = Convert.ToInt32(Console.ReadLine()); //takes in the user's answer (assigned int to num2)
                Console.WriteLine(obj.Addition(num, num2)); //adds num and num 2 and writes it to the console

            }
            catch //catch block
            {
                Console.WriteLine(obj.Addition(num)); //if the user does not enter a number program prints out object method num (our original value)
            }
            Console.ReadLine(); //print final result to the screen
        }
    }
}
