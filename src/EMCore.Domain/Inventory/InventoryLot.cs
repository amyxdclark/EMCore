namespace EMCore.Domain.Inventory;

using EMCore.Domain.Common;

public class InventoryLot : TenantEntity
{
    public Guid InventoryItemId { get; set; }
    public InventoryItem InventoryItem { get; set; } = null!;

    public string LotNumber { get; set; } = string.Empty;
    public DateOnly? ExpirationDate { get; set; }
    public int Quantity { get; set; }
}
