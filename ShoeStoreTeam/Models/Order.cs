using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Models
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime NgayGiao { get; set; }
        public DateTime NgayDat { set; get; }
        public bool TinhTrang { set; get; }
        public double TongTien { set; get; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}