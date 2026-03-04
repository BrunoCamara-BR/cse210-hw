using System;

class Program
{
    static void Main(string[] args)
    {
        string msg = "";
        Random randomGenerator = new Random();
        string playAgain;
        int guessNumber;

        // The game
        do
        {
            // Generate the magic number
            int magicNumber = randomGenerator.Next(1, 100);
            int attemp = 0;

            // Guessing game
            do
            {
                // ask for the guess number
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                attemp++;

                // if statements
                if (magicNumber == guessNumber)
                {
                    msg = "You guessed it!";
                }
                else if (magicNumber > guessNumber)
                {
                    msg = "Higher";
                }
                else
                {
                    msg = "Lower";
                }
                Console.WriteLine(msg);
                Console.WriteLine($"Attemp number: {attemp}");
            } while (magicNumber != guessNumber);

            // ask for keep in game.
            Console.Write("Play again (yes/no)? ");
            playAgain = Console.ReadLine();

        }
        while (playAgain != "no");
    }


}