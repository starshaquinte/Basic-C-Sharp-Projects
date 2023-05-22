using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            division obj = new division();
            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            obj.Math(num1);
            int num2 = 0;
            obj.Math(out num1, out num2);
            Console.WriteLine("num1 is now " + num1);
            Console.WriteLine("num2 is now " + num2);
            MyStaticClass.MyStaticMethod();


            Console.ReadLine();

        }


    }
}
