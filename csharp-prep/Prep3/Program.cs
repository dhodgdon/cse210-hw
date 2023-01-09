using System;

class Program
{
    static void Main(string[] args)
    {
        string again;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            string loop = "True";
            int guessCount = 0;

            while (loop == "True")
            {
                guessCount += 1;

                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    loop = "False";
                }
            }

            Console.WriteLine($"You made {guessCount} guesses.");

            Console.Write("Do you want to play again? ");
            again = Console.ReadLine();
        } while (again == "yes");
    }
}