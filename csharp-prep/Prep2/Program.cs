using System;

class Program
{
    static void Main(string[] args)
    
    {//ask the user for their grade percentage

        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Declare a variable to store the letter grade and now sign
        string letter = "";
        string sign = "";

        // Determine the letter grade based on the percentage
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print the letter grade
        //Console.WriteLine($"Your letter grade is: {letter}");

        // Determine if the user passed the course
        //if (gradePercentage >= 70)
        {
          //  Console.WriteLine("Congratulations, you passed the course!");
        }
        //else
        {
          //  Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }

        // Determine the sign if the grade is not "F" or "A"
        if (letter != "F")
        {
            int lastDigit = gradePercentage % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

         // Handle special case for "A+" and "F+/F-"
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No "A+"
        }
        if (letter == "F")
        {
            sign = ""; // No "F+" or "F-"
        }

        // Print the letter grade with the sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }
    }

    
    
}