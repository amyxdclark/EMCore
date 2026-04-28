namespace EMCore.Domain.Subjects;

using EMCore.Domain.Common;

public class SubjectPropertyValue : TenantEntity
{
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;

    public Guid SubjectTypePropertyId { get; set; }
    public SubjectTypeProperty SubjectTypeProperty { get; set; } = null!;

    public string? Value { get; set; }
}
