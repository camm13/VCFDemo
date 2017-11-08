using System.Linq;
using VCF.Models;
using System.Web.Mvc;

namespace VCF.Controllers
{
    public class InventoryController : Controller
    {
        private ApplicationDbContext _dbContext;

        public InventoryController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Inventory
        public ActionResult ProductList()
        {
            var inventory = _dbContext.Inventory.ToList();

            return View(inventory);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Add(Inventory inventory)
        {
            _dbContext.Inventory.Add(inventory);
            _dbContext.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public ActionResult Edit(int id)
        {
            var inventory = _dbContext.Inventory.SingleOrDefault(v => v.Id == id);

            if (inventory == null)
                return HttpNotFound();

            return View(inventory);
        }
        [HttpPost]
        public ActionResult Update(Inventory inventory)
        {
            var inventoryInDb = _dbContext.Inventory.SingleOrDefault(v => v.Id == inventory.Id);

            if (inventoryInDb == null)
                return HttpNotFound();

            inventoryInDb.ProductName = inventory.ProductName;
            inventoryInDb.Description = inventory.Description;
            inventoryInDb.Price = inventory.Price;
            _dbContext.SaveChanges();

            return RedirectToAction("ProductList");
        }
        public ActionResult Delete(int id)
        {
            var inventory = _dbContext.Inventory.SingleOrDefault(v => v.Id == id);

            if (inventory == null)
                return HttpNotFound();

            return View(inventory);
        }
        [HttpPost]
        public ActionResult DoDelete(int id)
        {
            var inventory = _dbContext.Inventory.SingleOrDefault(v => v.Id == id);
            if (inventory == null)
                return HttpNotFound();
            _dbContext.Inventory.Remove(inventory);
            _dbContext.SaveChanges();
            return RedirectToAction("ProductList");

        }
    }
}