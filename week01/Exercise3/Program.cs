using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int magicNbr = randomGen.Next(1, 101);

        int guessN = -1;

        while (guessN != magicNbr)

        {
            Console.Write("What is your guess? ");
            guessN = int.Parse(Console.ReadLine());

            if (magicNbr > guessN)

            {
                Console.WriteLine("Higher");
            }

            else if (magicNbr < guessN)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You Guessed it!");
            }

        }

    }
}