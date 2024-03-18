﻿namespace Domain;

public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Sex Sex { get; set; }
    public string Email { get; set; }
}

public enum Sex
{
    Male,
    Female,
    Other
}
