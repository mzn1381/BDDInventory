using Inventory.Application.Contract.DTO.Inventory;
using Inventory.Application.Contract.Inventory.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Presentation.Controllers
{
[ApiController]
[Route("[controller]")]
    public class InventoryController:ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
         [HttpPost]
         public decimal Create(CreateInventoryViewModel model)
         {
           return _inventoryService.CreateInventory(model);;
         }
    }
}