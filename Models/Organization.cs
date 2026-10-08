using Univents.Models.Enums;

namespace Univents.Models;

public class Organization : User
{
    public string OrgName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Pending;
    public double AverageRating { get; set; }

    // UI fields carried over from the old OrganizationItem
    public string Tag { get; set; } = string.Empty;
    public string ThemeColor { get; set; } = "#c5e61c";

    public List<Event> Events { get; set; } = new();
    public List<OrganizationMembership> Members { get; set; } = new();

    public int MemberCount => Members.Count;
}
