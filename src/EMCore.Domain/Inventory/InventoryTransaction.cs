namespace EMCore.Domain.Inventory;

using EMCore.Domain.Common;

public class InventoryTransaction : TenantEntity
{
    public Guid InventoryItemId { get; set; }
    public InventoryItem InventoryItem { get; set; } = null!;

    public InventoryTransactionType TransactionType { get; set; }
    public int Quantity { get; set; }

    public Guid? FromSubjectId { get; set; }
    public Guid? ToSubjectId { get; set; }

    public string? LotNumber { get; set; }
    public string? Notes { get; set; }

    public Guid PerformedByUserId { get; set; }
    public DateTimeOffset TransactionDate { get; set; } = DateTimeOffset.UtcNow;
}
