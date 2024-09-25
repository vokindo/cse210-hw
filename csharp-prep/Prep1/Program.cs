using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their first name

        Console.Write("What is your first name?");
        string first_name = Console.ReadLine();

        // Prompt the user for their last name

        Console.Write("What is your last name?");        
        string last_name = Console.ReadLine();

        //Display Results
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}