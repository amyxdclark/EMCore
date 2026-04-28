namespace EMCore.Domain.Personnel;

using EMCore.Domain.Common;

public class CredentialType : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool HasExpiration { get; set; } = true;
    public int? WarnDaysBeforeExpiration { get; set; }
}
