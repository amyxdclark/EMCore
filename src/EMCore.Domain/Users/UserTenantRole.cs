namespace EMCore.Domain.Users;

using EMCore.Domain.Common;

public class UserTenantRole : TenantEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid RoleId { get; set; }
    public Role Role { get; set; } = null!;
}
