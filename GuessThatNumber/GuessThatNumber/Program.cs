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
            Console.Title = "Guess That Number!";
            Console.WriteLine("\n\n Let's play a game. What number am I thinking of between 1 and 100?");
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
            int guessCount = 0;

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
                    Console.WriteLine(" Guess higher.");
                    
                    //count a guess
                    guessCount++;
                }
                //userGuess is too high
                else if (input > randomNum)
                {
                    //Computer tells user to guess lower
                    Console.WriteLine();
                    Console.WriteLine(" Guess lower.");
                    

                    //count a guess
                    guessCount++;
                }
                //userGuess is correct
                else if (input == randomNum)
                {
                    //Computer congratulates the user
                    guessCount++;
                    Console.WriteLine();
                    Console.WriteLine(" You got it! It took you " + guessCount + " guess(es) to guess my number.");
                    Console.WriteLine();
                    break;
                    

                }
            }
            //game over
            //AddHighScore(guessCount);
            //DisplayHighScores();
        }
        //static void AddHighScore(int playerScore)
        //{
        //    //get the player name for high scores
        //    Console.WriteLine(" Your name:");
        //    string playerName = Console.ReadLine();

        //    //create a gateway to the database
        //    spAnthonyEntities db = new spAnthonyEntities();
            
        //    //create a new highscore object
        //    HighScore newHighScore = new HighScore();
        //    newHighScore.DateCreated = DateTime.Now;
        //    newHighScore.Game = "Guess That Number";
        //    newHighScore.Name = playerName;
        //    newHighScore.Score = playerScore;

        //    //add to the database
        //    db.HighScores.Add(newHighScore);
            
        //    //save our changes
        //    db.SaveChanges();
        //}
        //static void DisplayHighScores()
        //{
        //    //clear the console
        //    Console.Clear();
        //    //Write the High Score Text
        //    Console.WriteLine();
        //    Console.WriteLine("                      Guess That Number High Scores");
        //    Console.WriteLine("                      *****************************");

        //    //create a new connection to the db
        //    spAnthonyEntities db = new spAnthonyEntities();
        //    //get the high score list
        //    List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Guess That Number").OrderBy(x => x.Score).Take(10).ToList();

        //    foreach (HighScore highScore in highScoreList)
        //    {
        //        Console.WriteLine("                       {0}. {1} - {2} on {3}", highScoreList.IndexOf(highScore) + 1, highScore.Name, highScore.Score, highScore.DateCreated.Value.ToShortDateString());
        //    }
        //}
    }
}
