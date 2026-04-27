namespace EMCore.Domain.Personnel;

using EMCore.Domain.Common;

public class Credential : TenantEntity
{
    public Guid PersonId { get; set; }
    public Person Person { get; set; } = null!;

    public Guid CredentialTypeId { get; set; }
    public CredentialType CredentialType { get; set; } = null!;

    public string? CredentialNumber { get; set; }
    public DateOnly? IssuedDate { get; set; }
    public DateOnly? ExpirationDate { get; set; }
    public string? AttachmentUrl { get; set; }
}
