namespace EMCore.Domain.Scheduling;

using EMCore.Domain.Common;

public class Shift : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public ICollection<SchedulePeriod> Periods { get; set; } = new List<SchedulePeriod>();
}
