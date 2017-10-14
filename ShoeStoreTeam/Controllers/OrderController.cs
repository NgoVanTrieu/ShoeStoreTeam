using Microsoft.AspNet.Identity;
using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStoreTeam.Controllers
{
    public class OrderController : Controller
    {
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
        [Authorize]
        // GET: Order
        public ActionResult DatHang()
        {
            //Kiểm tra Đặt Hàng
            if (Session["Cart"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //Thêm Đơn Hàng
            Order order = new Order();
            List<Cart> gh = LayCart();
            order.UserId = User.Identity.GetUserId();
            order.NgayDat = DateTime.Now;
            order.NgayGiao = DateTime.Now;
            db.Orderes.Add(order);
            db.SaveChanges();
            //Thêm Chi Tiêt Don Hang
            foreach (var item in gh)
            {

                OrderDetail ctdh = new OrderDetail();
                ctdh.ProductId = item.IMaGiay;
                ctdh.OrderId = order.Id;
                ctdh.SoLuong = item.sSoLuong;
                ctdh.DonGia = (float)item.dDonGia;
                db.OrderDetailes.Add(ctdh);  
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}