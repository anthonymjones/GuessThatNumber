using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tell the user to guess a number, and call the numberGuess function
            
            Console.WriteLine("\n\nLet's play a game. Guess what number I'm thinking of between 1 and 100.");
            NumberGuess();

            //keep the window open
            Console.ReadKey();
            
        }

        //Create a function that creates a random number between 1 and 100, then asks the user for a guess.
        //When the user type a number, the program must tell you if you won, your guess is low, or your guess is high
        //When the user guesses the number correctly, the program must tell how many guesses it took
        static void NumberGuess()
        {
            

            //make a random number between 1 and 100
            Random compNum = new Random();
            int randomNum = compNum.Next(1, 101);

            //set variable for number of guesses
            int count = 0;

            //set place holder for converting guess string to an int
            int userGuess = 0;

            //Create a loop that runs until the user guesses the randomNumber
            while (userGuess != randomNum)
            {
                string guess = Console.ReadLine();


                //make guess string userGuess int
                int input = int.Parse(guess);
                
                //userGuess is too low
                if (input < randomNum)
                {
                    //Computer tells user to guess higher
                    Console.WriteLine();
                    Console.WriteLine("Guess higher.");
                    
                    //count a guess
                    count++;
                }
                //userGuess is too high
                else if (input > randomNum)
                {
                    //Computer tells user to guess lower
                    Console.WriteLine();
                    Console.WriteLine("Guess lower.");
                    

                    //count a guess
                    count++;
                }
                //userGuess is correct
                else if (input == randomNum)
                {
                    //Computer congratulates the user
                    count++;
                    Console.WriteLine();
                    Console.WriteLine("You got it! It took you " + count + " guess(es) to guess my number.");
                    break;
                    

                }
            }

        }

    }
}
