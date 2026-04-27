namespace EMCore.Domain.Users;

using EMCore.Domain.Common;

public class Role : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<UserTenantRole> UserTenantRoles { get; set; } = new List<UserTenantRole>();
}
