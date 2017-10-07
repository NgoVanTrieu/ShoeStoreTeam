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

        public Category Category { get; set; }
        public byte CategoryId { get; set; }

        public Company Company { get; set; }
        public byte CompanyId { get; set; }
    }
}