namespace Inventory.Application.Contract.DTO.Inventory
{
    public class CreateInventoryViewModel
    {
        public string ProductName { get; set; }
        public string InventoryName { get; set; }
        public int CountProduct { get; set; }
        public decimal UnitPrice { get; set; }
    }
}