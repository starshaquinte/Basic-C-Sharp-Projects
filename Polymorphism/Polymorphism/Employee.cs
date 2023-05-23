using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : IQuittable //inheriting IQuittable interface
    {
        public void Quit() //implementing quit method from interface IQuittable 
        {
            Console.WriteLine("Employee quit");
        }
    }
}
