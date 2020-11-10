using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

        private Models.ShopDbContext db = new Models.ShopDbContext();
        // GET: Product
        public ActionResult Index()
        {
            var products = db.Products.Include("Category");
            ViewBag.Products = products;
            return View();
        }


        public ActionResult New()
        {
            var categories = from cat in db.Categories
                             select cat;
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public ActionResult New(Product produs)
        {
            db.Products.Add(produs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Show(int id)
        {
            Product produs = db.Products.Find(id);
            ViewBag.Product = produs;
            ViewBag.Category = produs.Category;
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}