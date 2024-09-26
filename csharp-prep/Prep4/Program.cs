using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // Create a list to store the numbers
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to get the numbers from the user
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number); // Add the number to the list if it's not 0
            }
        } while (number != 0);

        // Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Compute the average
        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        // Find the maximum
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        // Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        // Sort the list
        numbers.Sort();

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Display the smallest positive number
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // Display the sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


        // Display the results
        //Console.WriteLine($"The sum is: {sum}");
        //Console.WriteLine($"The average is: {average}");
        //Console.WriteLine($"The largest number is: {max}");
    }
    
}