using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        bool isFinished = false;
        int sum = 0;
        float average = 0;
        int largestNumber = 0;
        int smallestNumber = int.MaxValue;
        while (isFinished != true)
        {
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                sum += userNumber;
                if (userNumber > largestNumber)
                {
                    largestNumber = userNumber;
                }
                if (userNumber < smallestNumber && userNumber > 0)
                {
                    smallestNumber = userNumber;
                }
            }
            else
            {
                isFinished = true;
                numbers.Sort();
                if (numbers.Count > 0)
                {
                    average = (float)sum / numbers.Count;
                }
                Console.WriteLine($"The sum is : {sum}");
                Console.WriteLine($"The average is : {average}");
                Console.WriteLine($"The largest number is : {largestNumber}");
                Console.WriteLine($"The smallest positive number is : {smallestNumber}");
                Console.WriteLine($"The sorted list is : {string.Join(", ", numbers)}");
            }
        }
    }
}