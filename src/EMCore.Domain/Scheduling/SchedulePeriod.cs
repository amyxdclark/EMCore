namespace EMCore.Domain.Scheduling;

using EMCore.Domain.Common;

public class SchedulePeriod : TenantEntity
{
    public Guid ShiftId { get; set; }
    public Shift Shift { get; set; } = null!;

    public DateOnly Date { get; set; }

    public ICollection<UnitAssignment> UnitAssignments { get; set; } = new List<UnitAssignment>();
    public ICollection<CrewAssignment> CrewAssignments { get; set; } = new List<CrewAssignment>();
}
