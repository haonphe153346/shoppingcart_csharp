using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ShoppingCart_PRN211.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public double? Price { get; set; }
        public int? Num { get; set; }
        public double? TotalNumber { get; set; }

        public virtual Order Order { get; set; }
        public virtual Shoe Product { get; set; }
    }
}
