using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<OrderDetail>();
        }

        public int CustomerId { get; set; }
        public string Email { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public byte? CustomerStatus { get; set; }

        public virtual ICollection<OrderDetail> Orders { get; set; }
    }
}
