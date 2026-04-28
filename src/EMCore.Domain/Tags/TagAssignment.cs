namespace EMCore.Domain.Tags;

using EMCore.Domain.Common;

public class TagAssignment : TenantEntity
{
    public Guid TagId { get; set; }
    public Tag Tag { get; set; } = null!;

    /// <summary>The ID of the entity being tagged (subject, inventory item, or person).</summary>
    public Guid EntityId { get; set; }

    /// <summary>Discriminator: "Subject", "InventoryItem", "Person".</summary>
    public string EntityType { get; set; } = string.Empty;
}
