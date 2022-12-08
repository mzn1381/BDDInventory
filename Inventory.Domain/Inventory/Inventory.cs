using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Domain.Inventory
{
    public class Inventory
    {
        internal Inventory()
        {
            
        }
        public Inventory(string productName, long unitPrice, string inventoryName, long countProduct)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            InventoryName = inventoryName;
            CountProduct = countProduct;
        }
        [Key]
        public long Id { get; set; }
        
        [Column("ProductName")]
        [MaxLength(150)]
        public string ProductName { get; }
        public long UnitPrice { get; }
        public string InventoryName { get; }
        public long CountProduct { get; }
    }
}