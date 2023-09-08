namespace MvcMovie.Models;

public class Post
{
    public Guid  Id { get; set; }

    public required  string Title { get; set; }

    public required string  Heading { get; set; }
    
    public required string  Content { get; set; }
    
    public required string  Description { get; set; }

    public required bool  Visible { get; set; }

    public ICollection<Tag> Tags { get; set; }

}