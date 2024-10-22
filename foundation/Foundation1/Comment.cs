public class Comment
{
    private string _name;
    private string _text;

    // Constructor to initialize comment details
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Method to return the comment details
    public string GetCommentDetails()
    {
        return $"{_name}: {_text}";
    }
}
