using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStoreTeam.Controllers
{
    public class BlogController : Controller
    {
        private ApplicationDbContext db;
        public BlogController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Blog
        public ActionResult Index()
        {
            var model = db.Bloges.ToList();
            return View(model);
        }
    }
}