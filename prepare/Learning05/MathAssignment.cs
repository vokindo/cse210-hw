// MathAssignment.cs
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor for the MathAssignment class that also calls the base class constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)  // Call to base class constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to return the list of homework for the math assignment
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
