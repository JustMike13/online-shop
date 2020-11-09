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

        private ShopDbContext db = new ShopDbContext();
        // GET: Product
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Product produs)
        {
            try
            {
                db.Products.Add(produs);
                db.SaveChanges();
                TempData["message"] = "produsul a fost adaugat cu succes";
                return RedirectToAction("New");
            }
            catch (Exception e)
            {
                return View("New");
            }
        }

        public ActionResult Show(int id)
        {
            Product produs = db.Products.Find(id);
            ViewBag.Produs = produs;
            return View();
        }


    }
}