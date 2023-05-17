using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        { 
        List<int> numOne = new List<int>() { 23, 25, 12, 75, 57 }; //List of integers
        


        bool validNumber = false; //setting bool to false 

        while (!validNumber) //while loop that says is NOT a valid number
        {
            try //try catch statement
            {
                Console.WriteLine("Pick a number:"); //tells user to pick a number
                int numberOne = Convert.ToInt32(Console.ReadLine()); //integer numberOne
                for (int i = 0; i < numOne.Count; i++) //for loop takes each interger in the list, (moves through the list) We put out loop in the try/catch statement
                {
                    Console.WriteLine("The number you chose divided by " + numOne[i] + " = " + numOne[i] / numberOne ); //this line divides the users chosen number and displays it on the screen
                }
                Console.ReadLine();
                validNumber = true; //sets validNumber to true
                

            }
            catch (Exception ex){ //catch creates an exception to run if the user
                Console.WriteLine(ex.Message); //this will ensure the proper error messges is displayed depending on with exception is thrown
                Console.ReadLine();

            }
           

        }Console.WriteLine("You are done with the try catch"); //program has emerged for my the try catch block
        Console.ReadLine();


        

        
        

    }
}
