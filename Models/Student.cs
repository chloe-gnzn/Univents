namespace Univents.Models;

public class Student : User
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;
    public int YearLevel { get; set; }
    public DateTime Birthdate { get; set; }

    public List<Rsvp> Rsvps { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
    public List<SavedEvent> SavedEvents { get; set; } = new();
    public List<OrganizationMembership> Memberships { get; set; } = new();
}
