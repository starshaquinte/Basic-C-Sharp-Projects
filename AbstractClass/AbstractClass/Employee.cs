﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }

    
    

 }

