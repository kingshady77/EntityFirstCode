using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFirstCode.Models;

namespace EntityFirstCode.Controllers
{
    public class NorthwindController : Controller
    {
        NorthWindContext db = new NorthWindContext();
        

        public ActionResult Index()
        {
            db.CategoriesTable.Create();
            db.ProductsTable.Create();
            return View();
        }
    }
}