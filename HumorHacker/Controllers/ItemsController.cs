using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HumorHacker.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Shirts()
        {
            return View();
        }
    }
}