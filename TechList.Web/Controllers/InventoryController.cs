using Microsoft.AspNetCore.Mvc;
using TechList.Business.Concrete;
using TechList.Entities.Concrete;

namespace TechList.Web.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryManager _inventoryManager;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                return View(inventory);
            }
            else
            {
                return View(inventory);
            }
        }

    }
}
