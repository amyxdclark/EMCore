using EMCore.Domain.Audit;
using EMCore.Domain.Checks;
using EMCore.Domain.Inventory;
using EMCore.Domain.Issues;
using EMCore.Domain.Maintenance;
using EMCore.Domain.Personnel;
using EMCore.Domain.Scheduling;
using EMCore.Domain.Subjects;
using EMCore.Domain.Tags;
using EMCore.Domain.Tenants;
using EMCore.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace EMCore.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    private Guid? _tenantId;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Platform-level
    public DbSet<Tenant> Tenants => Set<Tenant>();
    public DbSet<User> Users => Set<User>();

    // Tenant-scoped
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<UserTenantRole> UserTenantRoles => Set<UserTenantRole>();
    public DbSet<SubjectType> SubjectTypes => Set<SubjectType>();
    public DbSet<SubjectTypeProperty> SubjectTypeProperties => Set<SubjectTypeProperty>();
    public DbSet<Subject> Subjects => Set<Subject>();
    public DbSet<SubjectPropertyValue> SubjectPropertyValues => Set<SubjectPropertyValue>();
    public DbSet<SubjectPlacement> SubjectPlacements => Set<SubjectPlacement>();
    public DbSet<Tag> Tags => Set<Tag>();
    public DbSet<TagAssignment> TagAssignments => Set<TagAssignment>();
    public DbSet<InventoryCategory> InventoryCategories => Set<InventoryCategory>();
    public DbSet<InventoryItem> InventoryItems => Set<InventoryItem>();
    public DbSet<InventoryLot> InventoryLots => Set<InventoryLot>();
    public DbSet<SerializedAsset> SerializedAssets => Set<SerializedAsset>();
    public DbSet<InventoryTransaction> InventoryTransactions => Set<InventoryTransaction>();
    public DbSet<InventoryProfile> InventoryProfiles => Set<InventoryProfile>();
    public DbSet<InventoryProfileLine> InventoryProfileLines => Set<InventoryProfileLine>();
    public DbSet<CheckTemplate> CheckTemplates => Set<CheckTemplate>();
    public DbSet<CheckSection> CheckSections => Set<CheckSection>();
    public DbSet<CheckQuestion> CheckQuestions => Set<CheckQuestion>();
    public DbSet<CheckSchedule> CheckSchedules => Set<CheckSchedule>();
    public DbSet<CheckInstance> CheckInstances => Set<CheckInstance>();
    public DbSet<CheckResponse> CheckResponses => Set<CheckResponse>();
    public DbSet<MaintenanceSchedule> MaintenanceSchedules => Set<MaintenanceSchedule>();
    public DbSet<MaintenanceWorkOrder> MaintenanceWorkOrders => Set<MaintenanceWorkOrder>();
    public DbSet<MileageLog> MileageLogs => Set<MileageLog>();
    public DbSet<Shift> Shifts => Set<Shift>();
    public DbSet<SchedulePeriod> SchedulePeriods => Set<SchedulePeriod>();
    public DbSet<UnitAssignment> UnitAssignments => Set<UnitAssignment>();
    public DbSet<CrewAssignment> CrewAssignments => Set<CrewAssignment>();
    public DbSet<Person> Persons => Set<Person>();
    public DbSet<CredentialType> CredentialTypes => Set<CredentialType>();
    public DbSet<Credential> Credentials => Set<Credential>();
    public DbSet<TrainingCourse> TrainingCourses => Set<TrainingCourse>();
    public DbSet<TrainingRecord> TrainingRecords => Set<TrainingRecord>();
    public DbSet<HrDocument> HrDocuments => Set<HrDocument>();
    public DbSet<IssueType> IssueTypes => Set<IssueType>();
    public DbSet<Issue> Issues => Set<Issue>();
    public DbSet<AuditLogEntry> AuditLog => Set<AuditLogEntry>();

    /// <summary>Sets the current tenant context for query filtering.</summary>
    public void SetTenantId(Guid tenantId) => _tenantId = tenantId;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply global tenant query filters to all TenantEntity types
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var clrType = entityType.ClrType;
            if (clrType.IsSubclassOf(typeof(EMCore.Domain.Common.TenantEntity)))
            {
                var method = typeof(AppDbContext)
                    .GetMethod(nameof(ApplyTenantFilter),
                        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
                    .MakeGenericMethod(clrType);
                method.Invoke(this, new object[] { modelBuilder });
            }
        }
    }

    private void ApplyTenantFilter<T>(ModelBuilder modelBuilder)
        where T : EMCore.Domain.Common.TenantEntity
    {
        modelBuilder.Entity<T>().HasQueryFilter(e => _tenantId == null || e.TenantId == _tenantId);
    }
}
