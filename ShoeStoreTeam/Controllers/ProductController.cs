using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStoreTeam.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db;
        public ProductController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Product
        public ActionResult _LatestProduct()
        {
            var model = db.Products.Take(8).ToList();
            return PartialView(model);
        }
    }
}