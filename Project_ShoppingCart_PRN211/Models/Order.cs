using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ShoppingCart_PRN211.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public int? AccountId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public double TotalMoney { get; set; }
        public DateTime? Date { get; set; }
        public string Email { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
