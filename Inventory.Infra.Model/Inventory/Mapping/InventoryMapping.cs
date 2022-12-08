using Microsoft.EntityFrameworkCore;
using Inventory.Domain.Inventory;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Infra.Model.Inventory.Mapping;

public class InventoryMapping : IEntityTypeConfiguration<Domain.Inventory.Inventory>
{
    public void Configure(EntityTypeBuilder<Domain.Inventory.Inventory> builder)
    {
        builder.Property(c=>c.ProductName);
        // builder.HasKey(c=>c.Id);
        builder.Property(c=>c.CountProduct);
        builder.Property(c=>c.InventoryName);
        builder.Property(c=>c.UnitPrice);
    }
}
