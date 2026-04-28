namespace EMCore.Domain.Inventory;

using EMCore.Domain.Common;

public class InventoryProfileLine : TenantEntity
{
    public Guid InventoryProfileId { get; set; }
    public InventoryProfile InventoryProfile { get; set; } = null!;

    public Guid InventoryItemId { get; set; }
    public InventoryItem InventoryItem { get; set; } = null!;

    public int RequiredQuantity { get; set; }
    public int? MinimumQuantity { get; set; }
}
