using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class division

    {
        public void Math(int num1) //This is my divide by 2 method 
        {
            int result = num1 / 2;
            Console.WriteLine(result);
            
        }

        public void Math(out int num1, out int num2) //Output parameters method
        {
            num1 = 6;
            num2 = 2;
        }
    }

    public static class MyStaticClass //My static class
    {
        public static void MyStaticMethod() //static method
        {
            Console.WriteLine("This message is for my static class");
        }
    }
}
