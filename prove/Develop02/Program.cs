using System;  // Importing the System namespace for basic functionality
using System.Collections.Generic;  // For using List<T> for journal entries
using System.IO;  // For file input and output (I/O) operations

namespace JournalApp
{
    // Class representing a journal entry
    public class JournalEntry
    {
        // Properties for the prompt, response, and date of the entry
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        // Constructor to initialize a journal entry with a prompt and response
        public JournalEntry(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now;  // Automatically set the date to the current date
        }

        // Override the ToString() method to return a nicely formatted string
        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}, Prompt: \"{Prompt}\", Response: \"{Response}\"";
        }
    }

    // Class representing the journal, which holds a list of journal entries
    public class Journal
    {
        // Private list to store journal entries
        private List<JournalEntry> entries;

        // Constructor to initialize the entries list
        public Journal()
        {
            entries = new List<JournalEntry>();  // Creates an empty list of entries
        }

        // Method to add a new entry to the journal
        public void AddEntry(JournalEntry entry)
        {
            entries.Add(entry);  // Adds the entry to the list
        }

        // Method to display all entries in the journal
        public void DisplayEntries()
        {
            // If the journal is empty, notify the user
            if (entries.Count == 0)
            {
                Console.WriteLine("The journal is empty.");
            }
            else
            {
                // Loop through all entries and display each one
                foreach (var entry in entries)
                {
                    Console.WriteLine(entry);  // Calls ToString() on each entry
                    Console.WriteLine("-----------------------------");  // Separator line
                }
            }
        }

        // Method to save the journal entries to a CSV file
        public void SaveJournalToFile(string filename)
        {
            // Use a StreamWriter to write to the specified file
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Loop through all entries and write them in CSV format
                foreach (var entry in entries)
                {
                    // Save entry with quotation marks to handle commas or special characters in data
                    writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\"");
                }
            }
            // Confirm to the user that the journal has been saved
            Console.WriteLine($"Journal saved to {filename}");
        }

        // Method to load journal entries from a CSV file
        public void LoadJournalFromFile(string filename)
        {
            // Check if the file exists before attempting to load
            if (File.Exists(filename))
            {
                entries.Clear();  // Clear the current entries before loading new ones
                // Use a StreamReader to read the file
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;  // Holds each line from the file
                    // Loop through each line in the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line by ","
                        var parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                        // Check if the split resulted in the expected number of parts
                        if (parts.Length == 3)
                        {
                            // Clean up the quotes around the date, prompt, and response
                            string date = parts[0].Trim('"');
                            string prompt = parts[1].Trim('"');
                            string response = parts[2].Trim('"');

                            // Create a new JournalEntry object from the file data and add it to the list
                            entries.Add(new JournalEntry(prompt, response) { Date = DateTime.Parse(date) });
                        }
                    }
                }
                // Confirm that the journal has been loaded
                Console.WriteLine($"Journal loaded from {filename}");
            }
            else
            {
                // Notify the user if the file does not exist
                Console.WriteLine("File not found.");
            }
        }
    }

    // Main class for the program
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();  // Create a new journal instance
            // List of prompts to be randomly selected for journal entries
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            bool running = true;  // Boolean to keep the menu running

            // Main loop to keep the menu options running until the user exits
            while (running)
            {
                // Display the menu options
                Console.WriteLine("Journal App Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display journal entries");
                Console.WriteLine("3. Save journal to a file");
                Console.WriteLine("4. Load journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();  // Get user input for menu choice

                switch (choice)
                {
                    case "1":
                        // Write a new entry
                        Random random = new Random();  // Create a random number generator
                        string prompt = prompts[random.Next(prompts.Count)];  // Randomly select a prompt
                        Console.WriteLine($"Prompt: {prompt}");  // Display the prompt to the user
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();  // Get the user's response
                        journal.AddEntry(new JournalEntry(prompt, response));  // Create and add a new journal entry
                        break;

                    case "2":
                        // Display all entries in the journal
                        journal.DisplayEntries();  // Call the display method on the journal
                        break;

                    case "3":
                        // Save the journal to a file
                        Console.Write("Enter the filename to save the journal (e.g., journal.csv): ");
                        string saveFilename = Console.ReadLine();  // Get the filename from the user
                        journal.SaveJournalToFile(saveFilename);  // Save the journal to the file
                        break;

                    case "4":
                        // Load the journal from a file
                        Console.Write("Enter the filename to load the journal from (e.g., journal.csv): ");
                        string loadFilename = Console.ReadLine();  // Get the filename from the user
                        journal.LoadJournalFromFile(loadFilename);  // Load the journal from the file
                        break;

                    case "5":
                        // Exit the program
                        running = false;  // Set the loop condition to false to exit
                        break;

                    default:
                        // Handle invalid menu options
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();  // Add a blank line for formatting
            }
        }
    }
}
