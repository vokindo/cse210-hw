using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); // Call the function to display the welcome message
        string userName = PromptUserName(); // Call the function to get the user's name
        int userNumber = PromptUserNumber(); // Call the function to get the user's favorite number
        int squaredNumber = SquareNumber(userNumber); // Call the function to square the number
        DisplayResult(userName, squaredNumber); // Call the function to display the result
    }

    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square the user's number and return the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result with the user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
    
}