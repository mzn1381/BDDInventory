using FluentAssertions;
using Inventory.Application.Contract.DTO.Inventory;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using RestSharp;
namespace Inventory.Presentation.Test.Integration
{
    public class InventoryPresentationIntegrationTest
    {
        
        [Fact]
        public void Should_Create_Inventory()
        {
            //Arrange
            const string Url = "/Inventory";
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
           var restFullClient =new RESTFulApiFactoryClient(client);
           var model =new CreateInventoryViewModel()
           {
               CountProduct = 1,
               InventoryName="PC",
               ProductName = "IMac",
               UnitPrice = 45000000
           };
            //Act
          var res =   restFullClient.PostContentAsync<CreateInventoryViewModel,decimal>(Url,model).Result;
            //Assert
            res.Should().BeGreaterThan(0);
        }
    }
}