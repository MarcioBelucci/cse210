using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is the grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        
        if (grade >= 90)
        {
            if (grade % 10 >= 3)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }
        }
        else if (grade >= 80)
        {
            if (grade % 10 >= 7)
            {
                letter = "B+";
            }
            else if (grade % 10 <= 3)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
            if (grade % 10 >= 7)
            {
                letter = "C+";

            }
            else if (grade % 10 <= 3)
            {
                letter = "C-";

            }
            else
            {
                letter = "C";

            }
        }
        else if (grade >= 60)
        {
            if (grade % 10 >= 7)
            {
                letter = "D+";
            }
            else if (grade % 10 <= 3)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}