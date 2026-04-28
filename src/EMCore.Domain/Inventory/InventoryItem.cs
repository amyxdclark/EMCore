namespace EMCore.Domain.Inventory;

using EMCore.Domain.Common;

public class InventoryItem : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid CategoryId { get; set; }
    public InventoryCategory Category { get; set; } = null!;
    public bool IsControlledSubstance { get; set; }
    public bool IsSerialized { get; set; }
    public string? UnitOfMeasure { get; set; }

    public ICollection<InventoryLot> Lots { get; set; } = new List<InventoryLot>();
    public ICollection<SerializedAsset> SerializedAssets { get; set; } = new List<SerializedAsset>();
    public ICollection<InventoryTransaction> Transactions { get; set; } = new List<InventoryTransaction>();
}
