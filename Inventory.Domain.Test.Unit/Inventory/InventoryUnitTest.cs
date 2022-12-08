namespace Inventory.Domain.Test.Unit;

using FluentAssertions;
using Application.Contract.Builder;

public class InventoryUnitTest 
{
    [Fact]
    public void Invnetory_Should_Be_Created()
    {
        var inventoryBuilder = new InventoryBuilder();
        inventoryBuilder.WithProductName("IPhone");
        inventoryBuilder.WithInventoryName("IPhone");
        inventoryBuilder.WithUnitPrice(14000000);
        inventoryBuilder.WithCountProduct(5);
        var inventory = inventoryBuilder.Build();
        inventory.Should().NotBeNull();
    }

    [Fact]
     public void Invnetory_Properties_Should_Be_Equal_PropertyOn_Biulder()
    {
        const string ProductName = "IPhone";
        const string InventoryName = "AppleMobile";
        const long UnitPrice = 2245000;
        const int CountProduct = 5;
        var inventoryBuilder = new InventoryBuilder();
        inventoryBuilder.WithProductName(ProductName);
        inventoryBuilder.WithInventoryName(InventoryName);
        inventoryBuilder.WithUnitPrice(UnitPrice);
        inventoryBuilder.WithCountProduct(CountProduct);
        var inventory = inventoryBuilder.Build();
        inventory.CountProduct.Should().Be(CountProduct);
        inventory.InventoryName.Should().Be(InventoryName);
        inventory.UnitPrice.Should().Be(UnitPrice);
        inventory.ProductName.Should().Be(ProductName);
    }
}

