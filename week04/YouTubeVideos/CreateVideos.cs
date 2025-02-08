using System;
using System.Collections.Generic;

// Video.cs
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }
    
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } 
    private List<Comment> Comments { get; set; }
    
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }
    
    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }
    
    public int GetCommentCount()
    {
        return Comments.Count;
    }
    
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nTitle: {Title}\nAuthor: {Author}\nLength: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
    }
}