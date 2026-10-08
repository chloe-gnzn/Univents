using Univents.Models.Enums;

namespace Univents.Models;

// Supertype of Student and Organization (disjoint, total specialization).
public abstract class User
{
    public int UserId { get; set; }
    public string InstitutionalEmail { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserStatus UserStatus { get; set; } = UserStatus.Active;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
