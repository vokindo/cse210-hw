// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor for the WritingAssignment class that also calls the base class constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)  // Call to base class constructor
    {
        _title = title;
    }

    // Method to return information about the writing assignment
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
