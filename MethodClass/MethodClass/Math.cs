using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Math
    {
        public void CallingMethods(int num, int num2)
        {
            int result = num + 7;
            Console.WriteLine(num2);
        }

        public int Addition(int num, int num2 = 1)//created a class w/ a void method  takes two integers as parameters
        {
            int result = num + num2; //math operation done on the first integer
            Console.WriteLine(num2);
            return result;
        }
    }

}
