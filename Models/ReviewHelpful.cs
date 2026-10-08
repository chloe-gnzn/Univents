namespace Univents.Models;

// Composite key (StudentId, ReviewId): one "helpful" vote per student per review
public class ReviewHelpful
{
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public int ReviewId { get; set; }
    public Review? Review { get; set; }
    public DateTime MarkedAt { get; set; } = DateTime.UtcNow;
}
