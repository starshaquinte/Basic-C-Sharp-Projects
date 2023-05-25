using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() 
            { 
            new Employee(){ FirstName = "Joe", LastName = "Smith", ID = 1},
            new Employee(){ FirstName = "Jim", LastName = "Smith", ID = 2},
            new Employee(){ FirstName = "Jill", LastName = "Smith", ID = 3},
            new Employee(){ FirstName = "Joe", LastName = "Smith", ID = 4},
            new Employee(){ FirstName = "Kim", LastName = "Smith", ID = 5},
            new Employee(){ FirstName = "John", LastName = "Smith", ID = 6},
            new Employee(){ FirstName = "James", LastName = "Smith", ID = 7},
            new Employee(){ FirstName = "Bill", LastName = "Smith", ID = 8},
            new Employee(){ FirstName = "Alice", LastName = "Smith", ID = 9},
            new Employee(){ FirstName = "Ken", LastName = "Smith", ID = 10},

            };
            List<Employee> Joes = new List<Employee>(); //creates List
            foreach (Employee item in employees)
            {
                if (item.FirstName == "Joe")
                {
                    Joes.Add(item);

                }
            }
            foreach (Employee item in Joes)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.ID);
            }

            //using Lambda to find employees with the name Joe
            List<Employee> Joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee item in Joes)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.ID);
            }

            //using Lambda to find employees with IDs greater than 5
            List<Employee> greaterId = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee item in greaterId)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.ID);
            }
            Console.ReadLine();




        }
    }
}
