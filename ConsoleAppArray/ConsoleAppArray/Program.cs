using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

        Console.WriteLine("Select an index of the array:"); //Ask the user to select an index of the array
        int input = Convert.ToInt32(Console.ReadLine()); //created an integer varible to take in the user input 


        string[] stringArray = new string[4]; //initalized the array

        stringArray[0] = "somewhere"; //created a one demensional array of strings
        stringArray[1] = "over";
        stringArray[2] = "the";
        stringArray[3] = "rainbow";

        Console.WriteLine(stringArray[input]); //Print the string of the user's input on the screen
        Console.ReadLine();



        int[] numarray = new int[] { 46, 24, 75, 468, 763 }; //Array of integers 
        Console.WriteLine("select an index of the array"); //User selects an index of the array
        int number = Convert.ToInt32(Console.ReadLine()); //takes user's input to display that index on the screen.


        if (number >= 0 && number < numarray.Length)
        {
            Console.WriteLine(numarray[number]); //if statement for the numArray
        }

        else
        {
            Console.WriteLine("the index you selected does not exist"); //else statement prints to screen

        }


        List<string> intList = new List<string>(); //Initialize List


        intList.Add("My");  //Created a list of strings
        intList.Add("Name");
        intList.Add("is");
        intList.Add("Starsha");

        Console.WriteLine("Select an index of the list: "); //Ask the user to select an index of the list and display to the screen
        int index = Convert.ToInt32(Console.ReadLine()); //user input variable to take users input
        Console.WriteLine(intList[index]); // displays the index chosen to the screen







    }
    }

