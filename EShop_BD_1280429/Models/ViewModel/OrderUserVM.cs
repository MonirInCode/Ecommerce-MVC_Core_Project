using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop_BD_1280429.ViewModel
{
    public class OrderUserVM
    {
        public int InvoiceId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Bill { get; set; }
        public string Payment { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Nullable<byte> Status { get; set; }
    }
}