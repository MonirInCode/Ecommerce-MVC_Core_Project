using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop_BD_1280429.Models
{
    public class Invoice
    {
        public Invoice()
        {
            this.Orders = new HashSet<Order>();
        }

        public int InvoiceId { get; set; }
        public int UserId { get; set; }
        public int Bill { get; set; }
        public string Payment { get; set; }
        public DateTime InvoiceDate { get; set; }
        public byte Status { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}