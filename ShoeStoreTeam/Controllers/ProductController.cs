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

        public ActionResult DetailProduct(long proId)
        {
            var detail = db.Products.Find(proId);
            return View(detail);
        }

        public ActionResult ProductCategory(long CateId)
        {
            var detail = db.Products.Where(x=>x.Category.ParentId==CateId).ToList();
            return View(detail);
        }
    }
}