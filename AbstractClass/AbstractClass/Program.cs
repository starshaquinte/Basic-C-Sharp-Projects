using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample"; //setting the employee properties
            employee.LastName = "Student";
            employee.SayName(); //calling the method from the instantiated object



        }
    }
}
