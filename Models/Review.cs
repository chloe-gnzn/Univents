namespace Univents.Models;

public class Review
{
    public int ReviewId { get; set; }
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public int EventId { get; set; }
    public Event? Event { get; set; }

    public int StarRating { get; set; }          // 1..5
    public string Title { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsVerified { get; set; }         // true if the student attended

    public List<ReviewHelpful> HelpfulVotes { get; set; } = new();
    public int HelpfulCount => HelpfulVotes.Count;
}
