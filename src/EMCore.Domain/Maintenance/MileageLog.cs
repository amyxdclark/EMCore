namespace EMCore.Domain.Maintenance;

using EMCore.Domain.Common;

public class MileageLog : TenantEntity
{
    public Guid SubjectId { get; set; }
    public int Mileage { get; set; }
    public DateTimeOffset LoggedAt { get; set; } = DateTimeOffset.UtcNow;
    public Guid LoggedByUserId { get; set; }
    public string? Notes { get; set; }
}
