namespace Inventory.Domain.Inventory.Repostiroy
{
    public interface IInventoryRepository
    {
        public decimal Create(Inventory inventory);
    }
}