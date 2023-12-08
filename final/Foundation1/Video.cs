using System;

public class Video
{
    public string _videoTitle;
    public string _author;
    public double _videoLength;
    public List<Comment> _comments = new List<Comment>();

    public Video(string videoTitle, string author, double videoLength)
    {
        _videoTitle = videoTitle;
        _author = author;
        _videoLength = videoLength;
    }
    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_videoTitle} (By: {_author}) (Length: {_videoLength} seconds) ");
        Console.WriteLine();
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
    }
}