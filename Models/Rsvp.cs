using Univents.Models.Enums;

namespace Univents.Models;

// Composite key (StudentId, EventId)
public class Rsvp
{
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public int EventId { get; set; }
    public Event? Event { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public RsvpStatus RsvpStatus { get; set; } = RsvpStatus.Going;
}
