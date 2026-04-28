namespace EMCore.Domain.Maintenance;

using EMCore.Domain.Common;

public class MaintenanceSchedule : TenantEntity
{
    public Guid SubjectId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int? IntervalDays { get; set; }
    public int? IntervalMiles { get; set; }
    public DateOnly? NextDueDate { get; set; }
}
