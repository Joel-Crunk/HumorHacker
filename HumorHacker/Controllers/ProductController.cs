using HumorHacker.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumorHacker.Controllers
{
    public class ProductController : Controller
    {

        // GET: Product
        public ActionResult Product()
        {
            var db = new ProductContext();

            var allproducts = db.Products.ToList();
            return View(allproducts);
        }
    }
}