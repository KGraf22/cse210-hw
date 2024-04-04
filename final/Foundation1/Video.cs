using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> comments;


    
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine($"Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"{comment.UserName}:{comment.Text}");
        }
    }
    
}