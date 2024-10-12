using System;

public class Reference
{
    private string _book; // The book of the scripture
    private int _chapter; // The chapter number
    private int _verse; // The starting verse number
    private int _endVerse; // The ending verse number (optional)

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // For a single verse, start and end are the same
    }

    // Constructor for multiple verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse; // Sets the end verse
    }

    // Method to get the reference as a string
    public string GetReferenceString()
    {
        return _verse == _endVerse
            ? $"{_book} {_chapter}:{_verse}" // Single verse
            : $"{_book} {_chapter}:{_verse}-{_endVerse}"; // Multiple verses
    }
}
