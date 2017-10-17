using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStoreTeam.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            if (User.IsInRole("User"))
                return View();
            else 
                return RedirectToAction("Index", "Admin");
        }

        public ActionResult _Slider()
        {
            var model = db.Slides.ToList();
            return PartialView(model);
        }

        public ActionResult Search(FormCollection fc)
        {
            string name = fc["searchString"];
            var pro = db.Products.Where(x => x.Name.ToUpper().Contains(name.ToUpper())).OrderByDescending(x => x.Id).Take(8).ToList();
            return View(pro);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}