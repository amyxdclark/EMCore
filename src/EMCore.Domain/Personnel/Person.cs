namespace EMCore.Domain.Personnel;

using EMCore.Domain.Common;

public class Person : TenantEntity
{
    public Guid? UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<Credential> Credentials { get; set; } = new List<Credential>();
    public ICollection<TrainingRecord> TrainingRecords { get; set; } = new List<TrainingRecord>();
    public ICollection<HrDocument> HrDocuments { get; set; } = new List<HrDocument>();
}
