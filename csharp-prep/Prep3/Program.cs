using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";// Variable to track if the user wants to play again

        while (playAgain.ToLower()=="yes")
    
        {
            // Ask the user for the magic number
            //Console.Write("What is the magic number? ");
            //int magicNumber = int.Parse(Console.ReadLine());

            // Generate a random number between 1 and 100

            Random random = new Random ();
            int magicNumber = random.Next(1,101);// 1 is inclusive, 101 is exclusive



            // Ask the user for their guess
            //Console.Write("What is your guess? ");
            //int guess = int.Parse(Console.ReadLine());
            int guess = -1; //this value isn't among the guess numbers
            int guessCount = 0; // Keep track of the number of guesses

            // Loop until the guess is equal to the magic number
            while (guess != magicNumber)
            {
                Console.Write ("What is your guess?");
                guess = int.Parse(Console.ReadLine());

                // Increment the guess count
                guessCount++;
        

                // Determine if the guess is higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                    else if(guess > magicNumber)
                {
                    Console.WriteLine ("Lower");
                }
                    else
                {
                    Console.WriteLine ($"You guessed it! It took you {guessCount} guesses.");
                }
            }// Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine ("Thanks for playing!");
    }
}