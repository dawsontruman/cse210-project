using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate magic number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        // gameplay loop
        int guess;
        int guesses = 0;
        do
        {
            guesses += 1;
            Console.WriteLine("Guess a number.");
            guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"Yes! The magic number is {number}.");
                Console.WriteLine($"You got it in {guesses} guesses.");
            }
        } while (guess != number);
    }
}