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
            string output = "";

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
                output = "Wrong input, Start game again, and put in the right input. Cheers";
            }

            //STARTING GAME BASED ON LEVEL
            if (levels == "EASY")
            {
                //CREATING RANDOM NUMBER
                randomNumber = randm.Next(1,11);
                chances = 6;
                while (guess != randomNumber)
                {
                    if (chances > 1)
                    {
                        Console.WriteLine($"You have {chances} chances left.");
                        Console.Write("Guess the number between 1 and 10: ");
                        guess = int.Parse(Console.ReadLine());
                    }
                    else if (chances == 1)
                    {
                        Console.WriteLine($"You have {chances} chance left.");
                        Console.Write("Guess the number between 1 and 10: ");
                        guess = int.Parse(Console.ReadLine());
                    }
                    

                    if (guess == randomNumber && chances > 0)
                    {
                        output = $"You got it right. The random number was {randomNumber}";
                        break;
                    }

                    if (chances == 1)
                    {
                        output = "All attempts was wrong. Try again later";  
                        break;
                    }
                    chances -= 1;
                }
            }
            else if (levels == "MEDIUM")
            {
                randomNumber = randm.Next(1,21);
                chances = 4;
                while (guess != randomNumber)
                {
                    if (chances > 1)
                    {
                        Console.WriteLine($"You have {chances} chances left.");
                        Console.Write("Guess the number between 1 and 20: ");
                        guess = int.Parse(Console.ReadLine());
                    }
                    else if (chances == 1)
                    {
                        Console.WriteLine($"You have {chances} chance left.");
                        Console.Write("Guess the number between 1 and 20: ");
                        guess = int.Parse(Console.ReadLine());
                    }
                    

                    if (guess == randomNumber && chances > 0)
                    {
                        output = $"You got it right. The random number was {randomNumber}";
                        break;
                    }

                    if (chances == 1)
                    {
                        output = "All attempts was wrong. Try again later";  
                        break;
                    }
                    chances -= 1;
                }
            }
            else if (levels == "HARD")
            {
                randomNumber = randm.Next(1,51);
                chances = 3;
                while (guess != randomNumber)
                {
                    if (chances > 1)
                    {
                        Console.WriteLine($"You have {chances} chances left.");
                        Console.Write("Guess the number between 1 and 50: ");
                        guess = int.Parse(Console.ReadLine());
                    }
                    else if (chances == 1)
                    {
                        Console.WriteLine($"You have {chances} chance left.");
                        Console.Write("Guess the number between 1 and 50: ");
                        guess = int.Parse(Console.ReadLine());
                    }
                    

                    if (guess == randomNumber && chances > 0)
                    {
                        output = $"You got it right. The random number was {randomNumber}";
                        break;
                    }

                    if (chances == 1)
                    {
                        output = "All attempts was wrong. Try again later";  
                        break;
                    }
                    chances -= 1;
                }
            }
            Console.WriteLine(output);            
        }
    }
}
