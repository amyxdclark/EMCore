namespace EMCore.Domain.Personnel;

using EMCore.Domain.Common;

public class TrainingRecord : TenantEntity
{
    public Guid PersonId { get; set; }
    public Person Person { get; set; } = null!;

    public Guid TrainingCourseId { get; set; }
    public TrainingCourse TrainingCourse { get; set; } = null!;

    public DateOnly CompletedDate { get; set; }
    public string? CertificateUrl { get; set; }
    public bool IsApproved { get; set; }
    public Guid? ApprovedByUserId { get; set; }
}
