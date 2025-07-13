using System;

public class Comment
{
    private string _commentorName;
    private string _commentText;
    public Comment(string commentorName, string commentText)
    {
        _commentorName = commentorName;
        _commentText = commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_commentorName}");
        Console.WriteLine($"{_commentText}");
    }
}