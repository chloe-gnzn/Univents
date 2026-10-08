using Univents.Models.Enums;

namespace Univents.Models;

public class Event
{
    public int EventId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Venue { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public int MaximumCapacity { get; set; }
    public EventStatus CurrentStatus { get; set; } = EventStatus.Upcoming;

    // UI fields carried over from the old EventItem
    public string ImageUrl { get; set; } = string.Empty;
    public string ThemeColor { get; set; } = "#c5e61c";

    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public List<Rsvp> Rsvps { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();

    public int AttendingCount => Rsvps.Count(r => r.RsvpStatus == RsvpStatus.Going || r.RsvpStatus == RsvpStatus.Attended);
    public bool IsFull() => AttendingCount >= MaximumCapacity;
    public bool IsCompleted() => CurrentStatus == EventStatus.Completed;
    public bool AcceptsReviews() => IsCompleted();
    public double GetAverageRating() => Reviews.Count == 0 ? 0 : Math.Round(Reviews.Average(r => r.StarRating), 1);
}
