namespace EMCore.Domain.Subjects;

using EMCore.Domain.Common;

public class SubjectType : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool CanContainChildren { get; set; } = true;

    public ICollection<SubjectTypeProperty> Properties { get; set; } = new List<SubjectTypeProperty>();
    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
