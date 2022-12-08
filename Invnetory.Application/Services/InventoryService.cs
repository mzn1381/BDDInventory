using Inventory.Application.Contract.DTO.Inventory;
using Inventory.Application.Contract.Inventory.Service;
using Inventory.Domain.Inventory.Repostiroy;
namespace Invnetory.Application;
using Inventory.Domain.Inventory;

public class InventoryService : IInventoryService
{
    private IInventoryRepository _repository;
    public InventoryService(IInventoryRepository repository)
    {
     _repository = repository;   
    }
    public decimal CreateInventory(CreateInventoryViewModel model)
    {
        var invnetory = new Inventory(model.ProductName, (long)model.UnitPrice,model.InventoryName,model.CountProduct);
        return _repository.Create(invnetory);
    }
}
