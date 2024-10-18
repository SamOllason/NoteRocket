namespace NoteRocket.Client.Models;

public enum Category
{
    Learning,
    Scouts,
    Personal
}

public class Note
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public Category Category { get; set; }
}
