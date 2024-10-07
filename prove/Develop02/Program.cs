// Program.cs
using System;
using System.Collections.Generic;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            bool running = true;

            while (running)
            {
                Console.WriteLine("Journal App Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal entries");
                Console.WriteLine("3. Save journal to a file");
                Console.WriteLine("4. Load journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Random random = new Random();
                        string prompt = prompts[random.Next(prompts.Count)];
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry(new JournalEntry(prompt, response));
                        break;

                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter the filename to save the journal (e.g., journal.csv): ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveJournalToFile(saveFilename);
                        break;

                    case "4":
                        Console.Write("Enter the filename to load the journal from (e.g., journal.csv): ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadJournalFromFile(loadFilename);
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
