namespace EMCore.Domain.Inventory;

using EMCore.Domain.Common;

public class SerializedAsset : TenantEntity
{
    public Guid InventoryItemId { get; set; }
    public InventoryItem InventoryItem { get; set; } = null!;

    public string SerialNumber { get; set; } = string.Empty;
    public string? ModelNumber { get; set; }
    public DateOnly? PurchaseDate { get; set; }
    public DateOnly? WarrantyExpiration { get; set; }
    public string Status { get; set; } = "Active";
}
