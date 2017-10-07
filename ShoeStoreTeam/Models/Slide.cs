using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Models
{
    public class Slide
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Top { get; set; }
        public string Slogan { get; set; }
        public string Content { get; set; }
    }
}