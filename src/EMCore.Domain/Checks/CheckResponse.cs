namespace EMCore.Domain.Checks;

using EMCore.Domain.Common;

public class CheckResponse : TenantEntity
{
    public Guid CheckInstanceId { get; set; }
    public CheckInstance CheckInstance { get; set; } = null!;

    public Guid CheckQuestionId { get; set; }
    public CheckQuestion CheckQuestion { get; set; } = null!;

    public string? Value { get; set; }
    public bool? Passed { get; set; }
    public string? Notes { get; set; }
}
