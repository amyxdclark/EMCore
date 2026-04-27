namespace EMCore.Domain.Scheduling;

using EMCore.Domain.Common;

public class CrewAssignment : TenantEntity
{
    public Guid SchedulePeriodId { get; set; }
    public SchedulePeriod SchedulePeriod { get; set; } = null!;

    public Guid PersonId { get; set; }
    public Guid? UnitAssignmentId { get; set; }
    public bool HasAcceptedResponsibility { get; set; }
}
