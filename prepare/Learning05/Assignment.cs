// Assignment.cs
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor for the base class
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Protected method to allow access to _studentName in derived classes
    protected string GetStudentName()
    {
        return _studentName;
    }
}
