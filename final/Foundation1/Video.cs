using System;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video{
    private string _title;
    private string _author;
    private int _lenth;
    List<Comment> _comments;
    
    public Video ( string title, string author, int lenth){
        _title=title;
        _author=author;
        _lenth=lenth;
        _comments = new List<Comment>();
    }

    public void AddComment (){
        Console.Write("Please write person name for comment ");
        string name = Console.ReadLine();
        Console.Write("Please write your comment ");
        string text = Console.ReadLine();
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
        }
    public int GetNumberOfComments(){
        return _comments.Count();
    }
    public void DisplayVideoInfo(){
        Console.WriteLine($"The title is {_title}, author {_author}, lenth {_lenth} seconds, number of comments {GetNumberOfComments()}");
        Console.WriteLine("The comments are: ");
        foreach (Comment comment in _comments){
            Console.WriteLine (comment.GetCommentInfo());
        }
    }
}


