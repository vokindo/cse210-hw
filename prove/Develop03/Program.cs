using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static List<Scripture> _scriptures = new List<Scripture>(); // Library of scriptures

    public static void Main(string[] args)
    {
        LoadScripturesFromFile("scriptures.txt"); // Load scriptures from a file

        while (true)
        {
            // Select a random scripture from the library
            var randomScripture = GetRandomScripture();
            if (randomScripture == null) break;

            // Display the reference and scripture
            Console.WriteLine(randomScripture.GetReference().GetReferenceString());
            Console.WriteLine(randomScripture.GetDisplayText());

            // Prompt user to guess words
            while (true)
            {
                Console.WriteLine("Type 'quit' to exit or guess a word to hide it:");
                string userInput = Console.ReadLine()?.Trim();
                
                if (userInput == null || userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Exiting...");
                    return; // Exit the program
                }

                // Hide the guessed word
                HideWord(randomScripture, userInput);
                Console.WriteLine(randomScripture.GetDisplayText());

                // Check if all words are hidden
                if (AllWordsHidden(randomScripture))
                {
                    Console.WriteLine("Congratulations! You've hidden all the words.");
                    break; // Exit the inner loop to select a new scripture
                }
            }
        }
    }

    // Load scriptures from a file
    private static void LoadScripturesFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return;
        }

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length < 4) continue; // Ensure there are enough parts

            string book = parts[0].Trim();
            int chapter = int.Parse(parts[1].Trim());
            int verse = int.Parse(parts[2].Trim());
            string text = parts[3].Trim();

            // Create reference and scripture objects
            Reference reference = new Reference(book, chapter, verse);
            Scripture scripture = new Scripture(reference, text);
            _scriptures.Add(scripture); // Add to the library
        }
    }

    // Get a random scripture from the library
    private static Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0) return null; // No scriptures to choose from

        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }

    // Hide a word in the scripture
    private static void HideWord(Scripture scripture, string wordText)
    {
        foreach (var word in scripture.GetWords())
        {
            if (word.GetText().Equals(wordText, StringComparison.OrdinalIgnoreCase))
            {
                word.Hide(); // Hide the matching word
                break; // Stop searching after the first match
            }
        }
    }

    // Check if all words in the scripture are hidden
    private static bool AllWordsHidden(Scripture scripture)
    {
        foreach (var word in scripture.GetWords())
        {
            if (!word.IsHidden()) return false; // Found a visible word
        }
        return true; // All words are hidden
    }
}
