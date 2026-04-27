namespace EMCore.Domain.Checks;

using EMCore.Domain.Common;

public class CheckTemplate : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<CheckSection> Sections { get; set; } = new List<CheckSection>();
    public ICollection<CheckSchedule> Schedules { get; set; } = new List<CheckSchedule>();
}
