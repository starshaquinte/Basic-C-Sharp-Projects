using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        //Part One
        string[] stringArray = new string[5]; //A one demensional array of strings

        stringArray[0] = "I";
        stringArray[1] = "am";
        stringArray[2] = "eating";
        stringArray[3] = "an";
        stringArray[4] = "apple";

        Console.WriteLine("Please input some text."); //Asking the user to input text
        string text = Console.ReadLine();
        for (int i = 0; i < stringArray.Length; i++) //for loop that iterates through eah string in the array
        {
            stringArray[i] = stringArray[i] + text; //adds the users text input to the end of each string 
        }
        foreach (var item in stringArray) //Second loop
        {
            Console.WriteLine(item); //prints off each string in the array one at a time

        }

        //Part Two

        int count = 0;
        while (count  < 20)//changed condition to check count variable (to fix infinite loop)
        {
            count += 1;
            Console.WriteLine(count);
        }

        //Part Three
        int count2 = 1;
         while (count2 < 57) //while loop where the less than comparison is used to determine whether to continue iterating the loop
        {
            Console.WriteLine(count2);
            count2++;
        }
        int count3 = 5;
        while (count3 <= 10) //while loop where the less than or equal to comparison is used to determine whether to continue iterating the loop
        {
            Console.WriteLine(count3);
            count3++;
        }

        //Part Four
        List<string> flower = new List<string>()
        {
            "Carnation", "Orchid", "Rose", "Lily", "Tulip" //String List where each item in the string is unique
        };
        Console.WriteLine("Please choose a flower: "); //asking user to input text to choose a flower
        string flowerChoice = Console.ReadLine();

        if (flower.Contains(flowerChoice))
        {
            for (int i = 0; i < flower.Count; i++) //for loop that iterates through the list and then displays the index of the item that matches
            {
                if(flowerChoice == flower[i])//checks if the user put in text that isn't on the list
                {
                    Console.WriteLine(flower[i] + " is at index " + i);//tells user where their choice is on the index
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Your choice was not in the list."); //tells user that their choice isn't on the list 

        }
        //Part Five 
        List<string> states = new List<string>()
        {
            "Georgia", "Connecticut", "Nevada", "Oregon", "Georgia", "Texas" //List of string with 2 identical items 
        };
        Console.WriteLine("Please choose a state: "); //Ask the user to choose a state 
        string stateChoice = Console.ReadLine();

        if (states.Contains(stateChoice))
        {
            for (int i = 0; i < states.Count; i++) //for loop that iterates through the list
            {
                if (stateChoice == states[i])
                {
                    Console.WriteLine(states[i] + " is at index " + i);//displays indices of the items matching the user's selection
                }

            }
        }
        //Part Six
        List<string> cars = new List<string>()
        {
            "CarA", "CarB", "CarC", "CarD", "CarB" // list of string with 2 identical strings
        };
        List<string> CarLetters = new List<string>();

        foreach (string car in cars) //for each loop that evaluates each item on the list
        {
            if (CarLetters.Contains(car))
            {
                Console.WriteLine(car + " is a duplicate"); //message to display the string is a duplicate
            }
            else
            {
                Console.WriteLine(car + " item is unique"); //message to display the string is unique
                CarLetters.Add(car);

            }
        }
        Console.ReadLine();

        }
    }

