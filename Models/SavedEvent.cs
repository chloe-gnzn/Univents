namespace Univents.Models;

// Composite key (StudentId, EventId): the bookmark toggle on the Welcome page
public class SavedEvent
{
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public int EventId { get; set; }
    public Event? Event { get; set; }
    public DateTime SavedAt { get; set; } = DateTime.UtcNow;
}
