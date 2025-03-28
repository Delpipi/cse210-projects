public class Video
{
    //Member variables
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    //Constructors
    public Video()
    {
        _comments = new List<Comment>();
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    //Member Functions
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    // Getters and Setters
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

}