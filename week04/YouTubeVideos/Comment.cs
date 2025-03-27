public class Comment
{
    //Members variables
    private string _commenterFullName;
    private string _message;

    //Constructors
    public Comment() { }

    public Comment(string commenterFullName, string message)
    {
        _commenterFullName = commenterFullName;
        _message = message;
    }

    public void Display()
    {
        Console.WriteLine($"**{_commenterFullName}");
        Console.WriteLine($"   {_message}");
    }

}