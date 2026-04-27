namespace EMCore.Domain.Tenants;

using EMCore.Domain.Common;

public class Tenant : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? LogoUrl { get; set; }
    public string TimeZoneId { get; set; } = "UTC";
    public bool IsActive { get; set; } = true;
}
