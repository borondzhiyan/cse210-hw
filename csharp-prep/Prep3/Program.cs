using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        

        int guessNumber=0;
        int attempt = 0;
        bool isFinish=false;
        while (!isFinish)
        {   
            int theNumber = randomGenerator.Next(1, 100);
            attempt=0;
            while (guessNumber!=theNumber)
            {
                attempt++;
                Console.Write("What is your guess? ");
                string theGuess=Console.ReadLine ();
                guessNumber = int.Parse(theGuess);
                if (guessNumber<theNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber>theNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took {attempt} attempts");
                }
            }
            Console.WriteLine("Would you like to play again? yes/no ");
            string response=Console.ReadLine();
            if (response.ToLower() =="yes")
            {
                isFinish=false;
            }
            else 
                Console.WriteLine("Thank you, good bye!");
                isFinish=true;
        }
    
    }
}
