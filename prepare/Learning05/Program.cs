// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the base class (Assignment)
        Assignment simpleAssignment = new Assignment("Okoth Okindo", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());

        // Test the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Brian Okindo", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Okindo", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
