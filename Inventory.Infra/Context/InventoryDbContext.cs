using Inventory.Infra.Model.Inventory.Mapping;
namespace Inventory.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Domain.Inventory;

public class InventoryDbContext:DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> option):base(option)
        {
        }
        public DbSet<Inventory>  Inventories { get; set; }
        
         protected override void OnModelCreating(ModelBuilder builder)
        {   
            builder.ApplyConfiguration(new InventoryMapping());
            base.OnModelCreating(builder);
        }
    }
