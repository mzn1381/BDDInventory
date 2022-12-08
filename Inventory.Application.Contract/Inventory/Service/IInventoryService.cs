using Inventory.Application.Contract.DTO.Inventory;

namespace Inventory.Application.Contract.Inventory.Service
{
    public interface IInventoryService
    {
        public decimal CreateInventory(CreateInventoryViewModel model);
    }
}