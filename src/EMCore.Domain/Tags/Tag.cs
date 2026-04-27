namespace EMCore.Domain.Tags;

using EMCore.Domain.Common;

public class Tag : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Color { get; set; }
    public string? Icon { get; set; }
    public bool ApplyToSubjects { get; set; } = true;
    public bool ApplyToInventory { get; set; } = true;
    public bool ApplyToPersons { get; set; } = true;

    public ICollection<TagAssignment> Assignments { get; set; } = new List<TagAssignment>();
}
