namespace Univents.Models;

// Composite key (StudentId, OrganizationId): the "Join" button on organization cards
public class OrganizationMembership
{
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}
