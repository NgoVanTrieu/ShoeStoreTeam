using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Models
{
    public class Category
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public byte ParentId { get; set; }
        public int DisplayOrder { get; set; }
    }
}