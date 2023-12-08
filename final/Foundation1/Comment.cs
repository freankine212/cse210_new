using System;

public class Comment
{
    public string _commenter;
    public string _comment;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_commenter} - {_comment}");
    }
}