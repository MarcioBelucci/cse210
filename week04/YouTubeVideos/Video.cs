using System.Net;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(comment)
    {
        _comments = new List<Comment>();
        _comments.Add(comment);
        
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public string GetTilet()
    {
        
    }

    public string GetAuthor()
    {
        
    }

    public int GetLength()
    {

    }

    public List<Comment> GetComments()
    {
        
    }
}