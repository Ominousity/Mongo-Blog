namespace Domain;

public class Comment
{
    public int CommentId { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }
    public int PostId { get; set; }
    public User User { get; set; }
}
