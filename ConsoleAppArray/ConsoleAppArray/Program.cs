using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

        Console.WriteLine("Select an index of the array:");
        int input = Convert.ToInt32(Console.ReadLine());


        string[] stringArray = new string[4];

        stringArray[0] = "somewhere";
        stringArray[1] = "over";
        stringArray[2] = "the";
        stringArray[3] = "rainbow";

        Console.WriteLine(stringArray[input]);
        Console.ReadLine();



        int[] numarray = new int[] { 46, 24, 75, 468, 763 };
        Console.WriteLine("select an index of the array");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 0 && number < numarray.Length)
        {
            Console.WriteLine(numarray[number]);
        }

        else
        {
            Console.WriteLine("the index you selected does not exist");

        }


        List<string> intList = new List<string>();


        intList.Add("My");
        intList.Add("Name");
        intList.Add("is");
        intList.Add("Starsha");

        Console.WriteLine("Select an index of the list: ");
        int index = Console.ReadLine(intList[0]);







    }
    }

