using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //INITIALIZING VARIABLES
            int randomNumber;
            int guess = 0;
            int chances = 0;
            Random randm = new Random();
            string levels = "";
            string wrongInputOutput = "";

            Console.Write("Choose a Level Between Easy, Medium and Hard. 1 for Easy, 2 for Medium and 3 for Hard: ");
            int numberChosen = int.Parse(Console.ReadLine());

            //SETTING LEVEL OF GAME
            if (numberChosen == 1)
            {
                levels = "EASY";
            }
            else if (numberChosen == 2)
            {
                levels = "MEDIUM";
            }
            else if (numberChosen == 3)
            {
                levels = "HARD";
            }
            else
            {
                wrongInputOutput = "Wrong input, Start game again, and put in the right input. Cheers";
            }

            //STARTING GAME BASED ON LEVEL
            if (levels == "EASY")
            {
                //CREATING RANDOM NUMBER
                try
                {
                    randomNumber = randm.Next(1,11);
                    chances = 6;

                    Console.WriteLine(playGame(1,10,chances,randomNumber,guess));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Start game again!!!");
                }
                
            }
            else if (levels == "MEDIUM")
            {
                try
                {
                    randomNumber = randm.Next(1,21);
                    chances = 4;

                    Console.WriteLine(playGame(1,20,chances,randomNumber,guess));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Start game again!!!");
                }
            }
            else if (levels == "HARD")
            {
                try
                {
                    randomNumber = randm.Next(1,51);
                    chances = 3;

                    Console.WriteLine(playGame(1,50,chances,randomNumber,guess));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Start game again!!!");
                } 
            }
            Console.WriteLine(wrongInputOutput);            
        }

        //Method that plays the game so that i don't repeat myself
        private static string playGame(int minValue, int maxValue, int gameChance, int gameRandomNumber, int gameGuess) 
        {
            string gameOutput = "";
            while (gameGuess != gameRandomNumber)
            {
                if (gameChance > 1)
                {
                    Console.WriteLine($"You have {gameChance} chances left.");
                    Console.Write($"Guess the number between {minValue} and {maxValue}: ");
                    gameGuess = int.Parse(Console.ReadLine());
                }
                else if (gameChance == 1)
                {
                    Console.WriteLine($"You have {gameChance} chance left.");
                    Console.Write($"Guess the number between {minValue} and {maxValue}: ");
                    gameGuess = int.Parse(Console.ReadLine());
                }
                        

                if (gameGuess == gameRandomNumber && gameChance > 0)
                {
                    gameOutput = $"You got it right. The random number was {gameRandomNumber}";
                    break;
                }

                if (gameChance == 1)
                {
                    gameOutput = "All attempts was wrong. Try again later";  
                    break;
                }
                gameChance -= 1;
            }
            return gameOutput;
        }
    }
}
