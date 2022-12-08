using Inventory.Application.Contract.DTO.Inventory;
using Inventory.Domain.Inventory.Repostiroy;
using Invnetory.Application;
using NSubstitute;

namespace Inventory.Application.Test.Unit.Services.Inventory;
using Domain.Inventory;

    public class ServiceInventoryUnitTest
    {
        
        [Fact]
        public void Should_Create_Inventory()
        {
            //arrange
            var repository = Substitute.For<IInventoryRepository>();
            var service = new InventoryService(repository);
            var model = new CreateInventoryViewModel()
            {
                ProductName="Test",
                InventoryName="T",
                CountProduct=4,
                UnitPrice=1200
            };
            //act
            service.CreateInventory(model);
            //assert
            repository.Received().Create(Arg.Any<Inventory>());
        }
    }
