using Inventory.Application.Contract.DTO.Inventory;
using Inventory.Application.Contract.Inventory.Service;
using Inventory.Presentation.Controllers;
using NSubstitute;

namespace Inventory.Presentation.Unit
{
    public class InventoryControllerUnitTest
    {
        [Fact]
        public void Should_Create_Inventory()
        {
            //Arrange
             var service =Substitute.For<IInventoryService>();
               var controller = new InventoryController(service);
               var model = new CreateInventoryViewModel();
            //Act
            controller.Create(model);
            //Assert
            service.Received().CreateInventory(Arg.Any<CreateInventoryViewModel>());
        }
    }
}