using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    [ValidateInput(false)]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (ShoppingListDbContext db = new ShoppingListDbContext())
            {
                List<Product> products = db.Products.ToList();

                return View(products);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                using (ShoppingListDbContext db = new ShoppingListDbContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    return Redirect("/");
                }
            }
            return View();
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (ShoppingListDbContext db = new ShoppingListDbContext())
            {
                Product product = db.Products.Find(id);

                if (product == null)
                {
                    return RedirectToAction("Index");
                }

                return View(product);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Product productModel)
        {
            if (ModelState.IsValid)
            {
                using (ShoppingListDbContext db = new ShoppingListDbContext())
                {
                    Product productFromDb = db.Products.Find(productModel.Id);
                    if (productFromDb != null)
                    {
                        productFromDb.Priority = productModel.Priority;
                        productFromDb.Name = productModel.Name;
                        productFromDb.Quantity = productModel.Quantity;
                        productFromDb.Status = productModel.Status;
                        db.SaveChanges();
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }
}