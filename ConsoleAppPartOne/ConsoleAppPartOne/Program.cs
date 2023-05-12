using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        string[] stringArray = new string[5];

        stringArray[0] = "I";
        stringArray[1] = "am";
        stringArray[2] = "eating";
        stringArray[3] = "an";
        stringArray[4] = "apple";

        Console.WriteLine("Please input some text.");
        string text = Console.ReadLine();

        foreach (string text in stringArray);
        {
            Console.WriteLine(stringArray + [text]);
        }
        {
            Console.WriteLine(stringArray[]);
        }

        }
    }

