using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int attempts = 0;
        string userInput = "yes";
        while (userInput.ToLower() == "yes")
        {
            Console.WriteLine("Guess the magic number between 1 and 100");

            for (int userGuess = 0; userGuess != magicNumber;)
            {
                Console.Write("Enter your guess: ");
                userGuess = int.Parse(Console.ReadLine());
                attempts++;
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the magic number {magicNumber} in {attempts} attempts.");
                    break;
                }
            }
            
            Console.Write("Do you want to play again? (yes/no): ");
            userInput = Console.ReadLine();
        }
    }
}