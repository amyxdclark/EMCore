namespace EMCore.Domain.Issues;

using EMCore.Domain.Common;

public class IssueType : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<Issue> Issues { get; set; } = new List<Issue>();
}
