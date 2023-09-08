namespace MvcMovie.Models;

public class Tag
{
    public Guid  Id { get; set; }

    public required string Name { get; set; } 
    
    public required string DisplayName { get; set; }
    
    public required ICollection<Post> Posts { get; set; }

}