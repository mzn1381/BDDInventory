using Inventory.Infra.Context;
using Inventory.Infra.Inventory.Repository;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infra.Test.Integration.Inventory;
using Domain.Inventory;
using FluentAssertions;

public class InventoryRepositoryIntegrationTest
    {
        private const string ConnectionString = "User ID=postgres;Password=00111381;Host=localhost;Port=5432;Database=InventoryBddProject;";
        private DbContextOptions<InventoryDbContext> _dbContextOption;
        private InventoryDbContext _dbContext;
        private InventoryRepository _inventoryRepository;
        public InventoryRepositoryIntegrationTest()
        {
             _dbContextOption =new DbContextOptionsBuilder<InventoryDbContext>().
             UseNpgsql(ConnectionString).Options;
             _dbContext = new InventoryDbContext(_dbContextOption);
             _inventoryRepository = new InventoryRepository(_dbContext);

        }
        [Fact]
        public void  Should_Be_Created_Inventory()
        {
            //Arrange
        const string ProductName = "IPhone12";
        const string InventoryName = "AppleMobile";
        const long UnitPrice = 2245000;
        const int CountProduct = 5;  
        var inventory = new Inventory(ProductName,UnitPrice,InventoryName,CountProduct);
        //Act
        var res = _inventoryRepository.Create(inventory);
        //Assert
        res.Should().BeGreaterThan(0);
        }
    }
