using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments; // List to store comments

    // Constructor to initialize video details
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); // Initialize the comment list
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to return video details
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        // Display all comments
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment.GetCommentDetails());
        }
    }
}
