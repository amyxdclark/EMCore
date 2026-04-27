namespace EMCore.Domain.Subjects;

using EMCore.Domain.Common;

public class SubjectTypeProperty : TenantEntity
{
    public Guid SubjectTypeId { get; set; }
    public SubjectType SubjectType { get; set; } = null!;

    public string Name { get; set; } = string.Empty;
    public string DataType { get; set; } = "string";
    public bool IsRequired { get; set; }
    public int DisplayOrder { get; set; }
}
