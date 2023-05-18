using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Integer //created a class named Integer
    {
        public int addition(int num) //access modifier that the method can be called publically - created a method called integer- using the int num parameters
        {
            int result = num + num; //addition operation using integer data type
            return result; //return statement, returns the value back from the addition operation
        }

        public int subtraction(int num2)
        {
            int result = num2 - num2; //subtraction operation using integer data type
            return result;
        }

        public int multiplication(int num3)
        {
            int result = num3 * num3;
            return result;
        }
    }
}
