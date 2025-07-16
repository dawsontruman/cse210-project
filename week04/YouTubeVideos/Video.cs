using System;

public class Video
{
    private string _author;
    private string _title;
    private int _length; // units of seconds
    List<Comment> _comments = new List<Comment>();
    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}