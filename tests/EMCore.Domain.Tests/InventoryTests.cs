using EMCore.Domain.Inventory;
using Xunit;

namespace EMCore.Domain.Tests;

public class InventoryTests
{
    [Fact]
    public void InventoryTransaction_TransactionType_ShouldBeCorrect()
    {
        var transaction = new InventoryTransaction
        {
            Id = Guid.NewGuid(),
            TenantId = Guid.NewGuid(),
            InventoryItemId = Guid.NewGuid(),
            TransactionType = InventoryTransactionType.Receive,
            Quantity = 10,
            PerformedByUserId = Guid.NewGuid()
        };

        Assert.Equal(InventoryTransactionType.Receive, transaction.TransactionType);
        Assert.Equal(10, transaction.Quantity);
    }

    [Theory]
    [InlineData(InventoryTransactionType.Receive)]
    [InlineData(InventoryTransactionType.Move)]
    [InlineData(InventoryTransactionType.Use)]
    [InlineData(InventoryTransactionType.Waste)]
    [InlineData(InventoryTransactionType.Adjust)]
    public void InventoryTransactionType_AllValues_AreValid(InventoryTransactionType type)
    {
        Assert.True(Enum.IsDefined(type));
    }

    [Fact]
    public void InventoryProfileLine_RequiredQuantity_ShouldBeSet()
    {
        var line = new InventoryProfileLine
        {
            Id = Guid.NewGuid(),
            TenantId = Guid.NewGuid(),
            InventoryProfileId = Guid.NewGuid(),
            InventoryItemId = Guid.NewGuid(),
            RequiredQuantity = 5,
            MinimumQuantity = 2
        };

        Assert.Equal(5, line.RequiredQuantity);
        Assert.Equal(2, line.MinimumQuantity);
    }
}
