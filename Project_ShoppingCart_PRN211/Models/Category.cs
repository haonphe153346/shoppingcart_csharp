using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ShoppingCart_PRN211.Models
{
    public partial class Category
    {
        public Category()
        {
            Shoes = new HashSet<Shoe>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Shoe> Shoes { get; set; }
    }
}
