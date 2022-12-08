namespace Inventory.Application.Contract.Builder{
using Domain.Inventory;
public class InventoryBuilder
{
    private string ProductName { get; set; }
    private string InventoryName { get; set; }
    private long UnitPrice { get; set; }
    private long CountProduct { get; set; }

    private  Inventory _inventory{get; set; }

    public InventoryBuilder WithProductName(string productName)
    {
       ProductName  = productName;
       return this;
    }

    public InventoryBuilder WithInventoryName(string inventoryName)
    {
        InventoryName = inventoryName;
        return this;
    }

    public InventoryBuilder WithUnitPrice(long unitPrice)
    {
        this.UnitPrice = unitPrice;
        return this;
    }

    public InventoryBuilder WithCountProduct(int countProduct)
    {
        CountProduct = countProduct;
        return this;
    }

    public Inventory  Build()
    {
        _inventory = new Inventory(ProductName,UnitPrice,InventoryName,CountProduct);
        return _inventory;
    }
}
}
