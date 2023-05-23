using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quitter = new Employee(); //object of type IQuittable
            quitter.Quit(); //calling quit method w/ quitter

        }
    }
}
