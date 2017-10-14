using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Models
{
    public class Company
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        ApplicationDbContext db = new ApplicationDbContext();

        public bool Update(Company entity)
        {
            try
            {
                var pro = db.Companies.Find(entity.Id);
                pro.Name = entity.Name;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public Company viewdetail(int id)
        {
            return db.Companies.Find(id);
        }
    }
}