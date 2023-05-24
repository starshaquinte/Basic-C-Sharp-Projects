using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2) //overloaded == operator 
        {
            return emp1.Id == emp2.Id; //checks if employee ids are equal

        }

        public static bool operator !=(Employee emp1, Employee emp2) //overloaded != operator 
        {
            return emp1.Id != emp2.Id; //checks if employee ids are not equal
        }

    }
}
