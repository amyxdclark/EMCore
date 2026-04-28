namespace EMCore.Domain.Personnel;

using EMCore.Domain.Common;

public class TrainingCourse : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal? CreditHours { get; set; }
    public bool IsMandatory { get; set; }
}
