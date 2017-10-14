using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Dao
{
    public class CategoryDao
    {
        ApplicationDbContext db = null;
        public CategoryDao()
        {
            db = new ApplicationDbContext();
        }
        public List<Category> ListAll()
        {
            return db.Categories.ToList();
        }
    }
}