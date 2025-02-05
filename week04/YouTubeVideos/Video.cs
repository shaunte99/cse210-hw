using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } 
    private List<Comment> VideoComments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        VideoComments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        VideoComments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return VideoComments.Count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");
        Console.WriteLine("User Comments:");
        foreach (var comment in VideoComments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}
