using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference; // Reference to the scripture
    private List<Word> _words; // List of words in the scripture

    // Constructor that accepts a Reference and the scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference; // Set the reference
        _words = new List<Word>(); // Initialize the word list

        // Split the text into words and create Word objects
        foreach (string wordText in text.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(wordText)); // Add new Word to the list
        }
    }

    // Method to get the reference
    public Reference GetReference()
    {
        return _reference;
    }

    // Method to get the words in the scripture
    public List<Word> GetWords()
    {
        return _words;
    }

    // Method to get the scripture text as a string
    public string GetScriptureText()
    {
        return string.Join(" ", _words.ConvertAll(word => word.GetText()));
    }

    // Method to get the display text of the scripture
    public string GetDisplayText()
    {
        return string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()));
    }
}
