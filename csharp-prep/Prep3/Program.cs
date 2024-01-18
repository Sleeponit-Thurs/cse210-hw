using System;

class Program
{
    static void Main(string[] args)
    {
        int tries = 0;
        while (true)
        {
        Random randomNumberGen = new Random();
        int magicNumber = randomNumberGen.Next(1,100);
        if (tries != 0)
        {
            Console.WriteLine("Would you like to play again? y/n");
            string response = Console.ReadLine();
            if (response == "y")
            {
                tries = 0;
                continue;
            }
            else if (response == "n")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
        
            while (true)
            {
                tries += 1;
                Console.WriteLine("Guess a number!");
                int guess = int.Parse(Console.ReadLine());
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess == magicNumber)
                {
                    Console.WriteLine($"You guessed it! It took {tries} tries.");
                    break;
                }

                
            }
        }

        
    }
}