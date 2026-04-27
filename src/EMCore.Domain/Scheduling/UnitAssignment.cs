namespace EMCore.Domain.Scheduling;

using EMCore.Domain.Common;

public class UnitAssignment : TenantEntity
{
    public Guid SchedulePeriodId { get; set; }
    public SchedulePeriod SchedulePeriod { get; set; } = null!;

    public Guid SubjectId { get; set; }
    public string? StationDesignation { get; set; }
}
