namespace EMCore.Domain.Checks;

using EMCore.Domain.Common;

public class CheckSchedule : TenantEntity
{
    public Guid CheckTemplateId { get; set; }
    public CheckTemplate CheckTemplate { get; set; } = null!;

    public Guid SubjectId { get; set; }
    public string Frequency { get; set; } = "Daily";
}
