
using ShoeStoreTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Dao
{
    public class CompanyDao
    {
        ApplicationDbContext db = null;
        public CompanyDao()
        {
            db = new ApplicationDbContext();
        }
        public List<Company> ListAll()
        {
            return db.Companies.ToList();
        }
    }
}