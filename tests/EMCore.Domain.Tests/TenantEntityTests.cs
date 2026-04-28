using EMCore.Domain.Common;
using EMCore.Domain.Subjects;
using EMCore.Domain.Tenants;
using Xunit;

namespace EMCore.Domain.Tests;

public class TenantEntityTests
{
    [Fact]
    public void TenantEntity_ShouldCarryTenantId()
    {
        var tenantId = Guid.NewGuid();
        var subject = new Subject
        {
            Id = Guid.NewGuid(),
            TenantId = tenantId,
            Name = "Ambulance 42",
            SubjectTypeId = Guid.NewGuid(),
            Status = SubjectStatus.Active
        };

        Assert.Equal(tenantId, subject.TenantId);
        Assert.Equal("Ambulance 42", subject.Name);
        Assert.Equal(SubjectStatus.Active, subject.Status);
    }

    [Fact]
    public void Tenant_ShouldBeActiveByDefault()
    {
        var tenant = new Tenant
        {
            Id = Guid.NewGuid(),
            Name = "Test EMS Agency"
        };

        Assert.True(tenant.IsActive);
        Assert.Equal("UTC", tenant.TimeZoneId);
    }

    [Fact]
    public void TenantEntity_CreatedAt_ShouldBeSetOnCreation()
    {
        var before = DateTimeOffset.UtcNow.AddSeconds(-1);
        var entity = new Subject
        {
            Id = Guid.NewGuid(),
            TenantId = Guid.NewGuid(),
            Name = "Station 1",
            SubjectTypeId = Guid.NewGuid()
        };
        var after = DateTimeOffset.UtcNow.AddSeconds(1);

        Assert.True(entity.CreatedAt >= before);
        Assert.True(entity.CreatedAt <= after);
    }

    [Fact]
    public void SubjectPlacement_ShouldLinkSubjectAndParent()
    {
        var tenantId = Guid.NewGuid();
        var subjectId = Guid.NewGuid();
        var parentId = Guid.NewGuid();

        var placement = new SubjectPlacement
        {
            Id = Guid.NewGuid(),
            TenantId = tenantId,
            SubjectId = subjectId,
            ParentSubjectId = parentId
        };

        Assert.Equal(subjectId, placement.SubjectId);
        Assert.Equal(parentId, placement.ParentSubjectId);
        Assert.Null(placement.RemovedAt);
    }
}
