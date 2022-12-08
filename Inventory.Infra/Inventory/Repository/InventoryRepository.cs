using Inventory.Domain.Inventory.Repostiroy;
using Inventory.Infra.Context;

namespace Inventory.Infra.Inventory.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private InventoryDbContext _dbContext;

        public InventoryRepository(InventoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public decimal Create(Domain.Inventory.Inventory inventory)
        {
             _dbContext.Add(inventory);
             _dbContext.SaveChanges();
            return inventory.Id;
        }
    }
}