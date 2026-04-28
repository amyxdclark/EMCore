namespace EMCore.Domain.Subjects;

using EMCore.Domain.Common;

public class Subject : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public Guid SubjectTypeId { get; set; }
    public SubjectType SubjectType { get; set; } = null!;

    public Guid? ParentSubjectId { get; set; }
    public Subject? ParentSubject { get; set; }
    public ICollection<Subject> ChildSubjects { get; set; } = new List<Subject>();

    public SubjectStatus Status { get; set; } = SubjectStatus.Active;
    public string? Notes { get; set; }

    public ICollection<SubjectPropertyValue> PropertyValues { get; set; } = new List<SubjectPropertyValue>();
    public ICollection<SubjectPlacement> Placements { get; set; } = new List<SubjectPlacement>();
}
