using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeStoreTeam.Models;
using Microsoft.AspNet.Identity;

namespace ShoeStoreTeam.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        ApplicationDbContext db = new ApplicationDbContext();
        public List<Cart> LayCart()
        {
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart == null)
            {
                //nếu giỏ hàng chưa tồn taik thì mình tiến hanh khởi tạo giỏ hàng(sesstionCart)
                lstCart = new List<Cart>();
                Session["Cart"] = lstCart;
            }
            return lstCart;
        }
        //Thêm giỏ hàng
        public ActionResult ThemCart(long magiay, string strURL)
        {
            Product p = db.Products.SingleOrDefault(n => n.Id == magiay);
            if (p == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lấy sesstion giỏ hàng
            List<Cart> lstCart = LayCart();
            //Kiểm tra sản phẩm này đã tồn tại trong sestion[Cart] chưa
            Cart sanpham = lstCart.Find(n => n.IMaGiay == magiay);
            if (sanpham == null)
            {
                sanpham = new Cart(magiay);
                //add sản phâm vào giỏ hàng
                lstCart.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.sSoLuong++;
                return Redirect(strURL);
            }

        }
        // cap nhat gio hang
        public ActionResult CapNhatCart(long magiay,FormCollection f)
        {
            Product p = db.Products.SingleOrDefault(n => n.Id == magiay);
            if (p == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Cart> lstCart = LayCart();
            Cart sanpham= lstCart.SingleOrDefault(n => n.IMaGiay == magiay);
            if (sanpham != null)
            {
                sanpham.sSoLuong =int.Parse(f["txtSoLuong"].ToString());
            }
            return RedirectToAction("Cart");
        }
        //Xoa Gio Hang
        public ActionResult XoaCart (long magiay)
        {
            Product p = db.Products.SingleOrDefault(n => n.Id == magiay);
            if (p == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Cart> lstCart = LayCart();
            Cart sanpham = lstCart.SingleOrDefault(n => n.IMaGiay == magiay);
            if (sanpham != null)
            {
                lstCart.RemoveAll(n => n.IMaGiay == magiay);
                
            }
            if (lstCart.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Cart");

        }
        public ActionResult Cart()
        {
            if (Session["Cart"] == null)
            {
                return RedirectToAction("TrangChu", "Home");
            }
            List<Cart> lstCart = LayCart();
            ViewBag.TongTien = TongTien();
            return View(lstCart);
        }
        //Tinh tong so luong va tong tien
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart != null)
            {
                iTongSoLuong = lstCart.Sum(n => n.sSoLuong);
            }
            return iTongSoLuong;
        }
        private double TongTien()
        {
            double dTongTien = 0;
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart != null)
            {
                dTongTien = lstCart.Sum(n => n.ThanhTien);

            }
            return dTongTien;
        }
        //tao partial gio hang
        public ActionResult CartPartial()
        {
            if(TongSoLuong() == 0){
                return PartialView();
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }
    }
}