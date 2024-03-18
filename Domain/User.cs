namespace Domain;

public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Sex Sex { get; set; }
    public List<int> Blogs { get; set; }
    public List<int> Posts { get; set; }
    public List<int> Comments { get; set; }
}

public enum Sex
{
    Male,
    Female,
    Other
}
