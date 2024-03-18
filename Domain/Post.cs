namespace Domain;

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }
    public User User { get; set; }
    public List<Comment> Comments { get; set; }
}
