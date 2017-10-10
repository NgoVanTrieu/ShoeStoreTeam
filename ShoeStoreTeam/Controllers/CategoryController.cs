using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStoreTeam.Controllers
{
    public class CategoryController : Controller
    {
         private ApplicationDbContext db;
        public CategoryController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Category
        public ActionResult _MenuBlock()
        {
            return PartialView("_MenuBlock",db.Categories.OrderBy(x => x.DisplayOrder).ToList());
        }

        public ActionResult ProductCategory(byte cateId)
        {
            var model = db.Products.Where(x => x.CategoryId == cateId).ToList();
            return View(model);
        }
    }
}