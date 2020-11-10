using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        private Models.ShopDbContext db = new Models.ShopDbContext();


        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
    }
}