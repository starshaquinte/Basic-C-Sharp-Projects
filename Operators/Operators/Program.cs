using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating two employee objects
            Employee employee = new Employee();
            Employee employee2 = new Employee(); 
            //assigning employee ids
            employee.Id = 1;
            employee2.Id = 2;
            Console.WriteLine(employee == employee2); //testing overload == operator to see if it works correctly
            Console.WriteLine(employee != employee2); //testing !=
            Console.ReadLine();





        }
    }
}
