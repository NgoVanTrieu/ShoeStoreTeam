using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoeStoreTeam.Models;
namespace ShoeStoreTeam.Models
{
    public class Cart
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public long IMaGiay { get; set; }
        public string sTenGiay { get; set; }
        public string sHinhAnh { get; set; }
        public double dDonGia { get; set; }
        public int sSoLuong { get; set; }
        public double ThanhTien
        {
            get { return sSoLuong * dDonGia; }
        }
        //Hàm Tạo Giỏ Hàng
        public Cart(long MaGiay)
        {
            IMaGiay = MaGiay;
            Product p = db.Products.Single(n => n.Id==IMaGiay);
            sTenGiay = p.Name;
            sHinhAnh = p.Image;
            dDonGia = double.Parse(p.Price.ToString());
            sSoLuong = 1;
        }
    }
}