using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoeStoreTeam.Models
{
    public class OrderDetail
    {

        public Product Product { set; get; }
        [Key]
        [Column(Order = 1)]
        public long ProductId { set; get; }
        public Order Order { set; get; }
        [Key]
        [Column(Order = 2)]
        public long OrderId { set; get; }
        public int SoLuong { set; get; }
        public double DonGia { set; get; }
    }
}