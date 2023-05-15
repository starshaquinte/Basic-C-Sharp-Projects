using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        //Part One
        string[] stringArray = new string[5];

        stringArray[0] = "I";
        stringArray[1] = "am";
        stringArray[2] = "eating";
        stringArray[3] = "an";
        stringArray[4] = "apple";

        Console.WriteLine("Please input some text.");
        string text = Console.ReadLine();
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = stringArray[i] + text;
        }
        foreach (var item in stringArray)
        {
            Console.WriteLine(item);

        }

        //Part Two

        int count = 0;
        while (count  < 20)//changed condition to check count variable 
        {
            count += 1;
            Console.WriteLine(count);
        }

        //Part Three
        int count2 = 1;
         while (count2 < 57)
        {
            Console.WriteLine(count2);
            count2++;
        }
        int count3 = 5;
        while (count3 <= 10)
        {
            Console.WriteLine(count3);
        }

        //Part Four
        List<string> flower = new List<string>()
        {
            "Carnation", "Orchid", "Rose", "Lily", "Tulip"
        };
        Console.WriteLine("Please choose a flower: ");
        string flowerChoice = Console.ReadLine();

        if (flower.Contains(flowerChoice))
        {
            for (int i = 0; i < flower.Count; i++)
            {
                if(flowerChoice == flower[i])
                {
                    Console.WriteLine(flower[i] + " is at index " + i);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Your choice was not in the list.");

        }
        //Part Five 
        List<string> states = new List<string>()
        {
            "Georgia", "Connecticut", "Nevada", "Oregon", "Georgia", "Texas"
        };
        Console.WriteLine("Please choose a state: ");
        string stateChoice = Console.ReadLine();

        if (states.Contains(stateChoice))
        {
            for (int i = 0; i < states.Count; i++)
            {
                if (stateChoice == states[i])
                {
                    Console.WriteLine(states[i] + " is at index " + i);
                }

            }
        }
        //Part Six
        List<string> cars = new List<string>()
        {
            "CarA", "CarB", "CarC", "CarD", "CarB"
        };
        List<string> CarLetters = new List<string>();

        foreach (string car in cars)
        {
            if cars ==
         }
        { 
            Console.WriteLine("This item is unique");
        }

        Console.ReadLine();

        }
    }

