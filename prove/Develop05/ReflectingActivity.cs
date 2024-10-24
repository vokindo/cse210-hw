using System.Collections.Generic;


public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private static Random rand = new Random();

    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on times in your life when you showed strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What is your favorite part of this experience?",
            "What did you learn about yourself?",
            "How can you apply this experience in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine(GetRandomPrompt());

        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);  // Pause for 5 seconds before showing the next question
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[rand.Next(_questions.Count)];
    }
}
