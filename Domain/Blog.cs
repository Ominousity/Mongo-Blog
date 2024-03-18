namespace Domain;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User User { get; set; }
    public List<int> Posts { get; set; }
}
