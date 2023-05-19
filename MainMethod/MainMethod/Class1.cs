using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Class1
    {
        public int addition(int num) //int parameter method
        {
            int result = num + 6;
            return result;
        }

        public int addition(decimal num) //decimal parameter method
        {
            int result = Convert.ToInt32
                (num) + 6;
            return result;
        }

        public int addition(string num) //string parameter method
        {
            int result = Convert.ToInt32
                (num) + 6;
            return result;
        }
    }
}
