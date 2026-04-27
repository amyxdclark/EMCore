namespace EMCore.Domain.Personnel;

using EMCore.Domain.Common;

public class HrDocument : TenantEntity
{
    public Guid PersonId { get; set; }
    public Person Person { get; set; } = null!;

    public string DocumentType { get; set; } = string.Empty;
    public string? DocumentUrl { get; set; }
    public DateOnly? DocumentDate { get; set; }
    public string? Notes { get; set; }
}
