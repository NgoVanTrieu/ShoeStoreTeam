using ShoeStoreTeam.Dao;
using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStoreTeam.Controllers
{
    public class AdminController : Controller
    {

        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public void SetViewBagCategory(int? selectid = null)
        {
            var dao = new CategoryDao();
            ViewBag.CategoryId = new SelectList(dao.ListAll(), "Id", "Name", selectid);
        }
        public void SetViewBagCompany(int? selectid = null)
        {
            var dao = new CompanyDao();
            ViewBag.CompanyId = new SelectList(dao.ListAll(), "Id", "Name", selectid);
        }

        //Thêm Xóa Sửa Product
        public ActionResult ShowProduct()
        {
            SetViewBagCategory();
            SetViewBagCompany();
            var product = db.Products.ToList();
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int ProductId)
        {
            SetViewBagCategory();
            SetViewBagCompany();
            var pro = new Product().viewdetail(ProductId);
            return View(pro);
        }
        [HttpPost]
        public ActionResult Edit(Product pro)
        {
            var dao = new Product();
            var result = dao.Update(pro);
            if (result == false)
            {
                ModelState.AddModelError("", "Cập nhập thất bại");

            }

            return RedirectToAction("ShowProduct");
        }
        [HttpGet]
        public ActionResult Delete(int ProductId)
        {
            Product pro = db.Products.SingleOrDefault(n => n.Id == ProductId);
            if (pro == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.Products.Remove(pro);
            db.SaveChanges();
            return RedirectToAction("ShowProduct");
        }
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBagCategory();
            SetViewBagCompany();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product pro)
        {
            db.Products.Add(pro);
            db.SaveChanges();
            return RedirectToAction("ShowProduct");
        }
        ///
        //Thêm Xóa Sửa Company
        ///

        [HttpGet]
        public ActionResult ShowCompany()
        {
            var company = db.Companies.ToList();
            return View(company);
        }

        [HttpGet]
        public ActionResult CreateCompany()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateCompany(Company com)
        {
            var model = db.Companies.ToList();
            foreach (var item in model)
            {
                if (com.Id == item.Id)
                {
                    Response.StatusCode = 404;
                    return null;
                }
            }
            db.Companies.Add(com);
            db.SaveChanges();
            return RedirectToAction("ShowCompany");



        }

        [HttpGet]
        public ActionResult DeleteCompany(int CompanyId)
        {
            Company com = db.Companies.SingleOrDefault(n => n.Id == CompanyId);
            if (com == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.Companies.Remove(com);
            db.SaveChanges();
            return RedirectToAction("ShowCompany");
        }

        //Sửa Công Ty
        [HttpGet]
        public ActionResult EditCompany(int CompanyId)
        {
            var com = new Company().viewdetail(CompanyId);
            return View(com);
        }
        [HttpPost]
        public ActionResult EditCompany(Company com)
        {
            var dao = new Company();
            var result = dao.Update(com);
            if (result == false)
            {
                ModelState.AddModelError("", "Cập nhập thất bại");

            }
            return RedirectToAction("ShowCompany");
        }
    }
}