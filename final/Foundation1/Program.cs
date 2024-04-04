// Abstraction with YouTube Videos
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Video 1","Author 1", 140),
            new Video("Video 2", "Author 2", 175),
            new Video("Video 3", "Author 3", 125)
        };

        foreach (var video in videos)
        {
            video.AddComment(new Comment("User 1", "Comment 1"));
            video.AddComment(new Comment("User 2", "Comment 2"));
            video.AddComment(new Comment ("User 3", "Comment 3"));
        }
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}