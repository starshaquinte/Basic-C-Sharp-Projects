using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the fruit!"); //guessing game where user must guess the fruit described
            Console.ReadLine();

            Console.WriteLine("The fruit is red"); //hint of what the mystery fruit is
            string fruit = Console.ReadLine();
            bool isGuessed = fruit == raspberry; //correct fruit name raspberry in bool data type

            do //do while statement
            {
                switch (fruit)
                {
                    case apple: //code block if user guesses apple 
                        Console.WriteLine("You guessed apple. Try again.");
                        Console.WriteLine("Guess the fruit!");
                        fruit = Console.ReadLine();
                        break;
                    case strawberry: //code block if user guesses strawberry
                        Console.WriteLine("You guessed strawberry. Try again.");
                        Console.WriteLine("Guess the fruit!");
                        fruit = Console.ReadLine();
                        break;
                    case tomato: //code block if user guesses tomato
                        Console.WriteLine("You guessed tomato. Try again");
                        Console.WriteLine("Guess the fruit!");
                        fruit = Console.ReadLine();
                        break;
                    case raspberry: //code block if user guesses raspberry
                        Console.WriteLine("You guessed raspberry! That is correct")
                        isGuessed = true;
                        break;
                    default: //code block if user guesses any other answer
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess the fruit!");
                        fruit = Console.ReadLine();
                        break;
                }
            }

            while (!isGuessed); //while statement
          

            Console.Read();



            }
                
            

        }
    }

