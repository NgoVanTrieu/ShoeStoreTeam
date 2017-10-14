using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

        public Category Category { get; set; }
        public byte CategoryId { get; set; }

        public Company Company { get; set; }
        public byte CompanyId { get; set; }

        ApplicationDbContext db = new ApplicationDbContext();

        public bool Update(Product entity)
        {
            try
            {
                var pro = db.Products.Find(entity.Id);
                pro.Name = entity.Name;
                pro.Price = entity.Price;
                pro.Size = entity.Size;
                pro.Color = entity.Color;
                pro.Description = entity.Description;
                pro.Image = entity.Image;
                pro.Link = entity.Link;
                pro.CategoryId = entity.CategoryId;
                pro.CompanyId = entity.CompanyId;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public Product viewdetail(int id)
        {
            return db.Products.Find(id);
        }
    }
}