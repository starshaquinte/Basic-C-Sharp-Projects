using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Math obj = new Math();

            obj.CallingMethods(8, 4); //calling the method in the class, passing two numbers
            obj.CallingMethods(num:8, num2:4); //calling the method in the class spcifying parameter by name 
            Console.ReadLine();

        }
    }
}
