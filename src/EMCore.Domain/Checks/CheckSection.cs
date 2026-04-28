namespace EMCore.Domain.Checks;

using EMCore.Domain.Common;

public class CheckSection : TenantEntity
{
    public Guid CheckTemplateId { get; set; }
    public CheckTemplate CheckTemplate { get; set; } = null!;

    public string Name { get; set; } = string.Empty;
    public int DisplayOrder { get; set; }

    public ICollection<CheckQuestion> Questions { get; set; } = new List<CheckQuestion>();
}
