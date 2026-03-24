using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(string author, string comment)
    {
        Comment newComment = new Comment(author, comment);
        _comments.Add(newComment);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine(comment.GetDisplayText());
        }
    }
}