class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment>comments=new();
    public Video(string title,string author,int length)
    {
        _author=author;
        _title=title;
        _length=length;
    }
    public int CommentNum()
    {
        return comments.Count();
    }
    public void Display()
    {
        Console.WriteLine($"{_title} - {_author}: {_length}sec, {CommentNum()} comments");
        Console.WriteLine("Comments: ");
        foreach(Comment comment in comments)
        {
            comment.Display();
        }
        Console.WriteLine("");
    }
    public void MakeComment(string name,string text)
    {
        comments.Add(new Comment(name,text));
    }
}