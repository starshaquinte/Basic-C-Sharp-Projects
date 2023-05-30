using System;

namespace Constructors
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int a = 70; //created a const variable
            var count = 37; //created a variable using the var keyword
            Console.WriteLine("Here is my const variable value: " + a); //Wrote const to the console
            Console.WriteLine("Here is my var variable value: " + count); //Wrote var to the console
            MyConstructor obj = new MyConstructor(); // calling the method
            Console.WriteLine(obj.num + " " + obj.hello); //writing object num and object hello to the console
            Console.ReadLine();
        }
        
    }
    public class MyConstructor
    {
        public int num;
        public string hello;

        public MyConstructor(int num, string hello)
        {
            this.num = num; //1st constructor takes an integer num
            this.hello = hello; //2nd constructor takes a string hello

        }
        public MyConstructor() : this(8, "Hello") // chaining two constructors together
        {

        }
    }
}

