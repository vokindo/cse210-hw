using System;

public class Word
{
    private string _text; // The text of the word
    private bool _isHidden; // The visibility of the word

    // Constructor that initializes the word text and sets isHidden to false (visible)
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, the word is visible
    }

    // Getter for the word text
    public string GetText()
    {
        return _text;
    }

    // Getter for the visibility status
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Method to get the display representation of the word
    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text; // Return underscores if hidden
    }
}
