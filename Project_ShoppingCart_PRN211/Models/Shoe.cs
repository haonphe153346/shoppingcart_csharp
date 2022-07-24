using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ShoppingCart_PRN211.Models
{
    public partial class Shoe
    {
        public Shoe()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ShoesId { get; set; }
        public string ShoesName { get; set; }
        public double ShoesPrice { get; set; }
        public int ShoesQuantity { get; set; }
        public string ShoesImage { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
