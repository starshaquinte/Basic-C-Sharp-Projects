using System;

namespace MathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Introduction to program 
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?"); 
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hourly rate is: " + hourlyRate1);  //Retrieves following details from person 1 input hourly rate and hours worked per week.

            Console.WriteLine("Hours worked per week?");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hours worked per week is: " + hoursWorked1);

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hourly rate is: " + hourlyRate2);//Retrieves following details from person 1 input hourly rate and hours worked per week.

            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hours worked per week is: " + hoursWorked2);

            Console.WriteLine("Annual salary of Person 1");
            int totalSalary1 = (hourlyRate1 * hoursWorked1)*52;
            Console.WriteLine("Annual salary of Person 1: " + totalSalary1); //Annual salary of person 1

            Console.WriteLine("Annual salary of Person 2");
            int totalSalary2 = (hourlyRate2 * hoursWorked2)*52;
            Console.WriteLine("Annual salary of Person 2: " + totalSalary2); //Annual salary of person 2 

            bool trueOrFalse = (totalSalary1 > totalSalary2);
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine(); //comparison of salary 1 to salary 2 to see who makes more.



        }
    }
}
