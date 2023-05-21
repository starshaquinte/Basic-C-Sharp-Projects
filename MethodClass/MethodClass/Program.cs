using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Math obj = new Math();

            Console.WriteLine(obj.CallingMethods(8, 4));
            Console.WriteLine(obj.CallingMethods(num1 + num2));
            Console.ReadLine();

        }
    }
}
