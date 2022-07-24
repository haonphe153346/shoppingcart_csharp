using System;
using System.Collections.Generic;

#nullable disable

namespace Project_ShoppingCart_PRN211.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string AccountEmail { get; set; }
        public string AccountPassword { get; set; }
        public string AccountName { get; set; }
        public string AccountPhone { get; set; }
        public string AccountAddress { get; set; }
        public bool? AccountRole { get; set; }
    }
}
