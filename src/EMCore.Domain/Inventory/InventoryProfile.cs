namespace EMCore.Domain.Inventory;

using EMCore.Domain.Common;

public class InventoryProfile : TenantEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<InventoryProfileLine> Lines { get; set; } = new List<InventoryProfileLine>();
}
