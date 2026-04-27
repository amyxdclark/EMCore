namespace EMCore.Domain.Inventory;

using EMCore.Domain.Common;

public class InventoryCategory : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<InventoryItem> Items { get; set; } = new List<InventoryItem>();
}
