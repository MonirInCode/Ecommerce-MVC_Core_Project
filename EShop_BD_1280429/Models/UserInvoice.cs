using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EShop_BD_1280429.Models
{
    public class UserInvoice
    {
        
        
            [Key]
            public int InvoiceId { get; set; }
            public string Customer { get; set; }
            public int Bill { get; set; }
            public string Payment { get; set; }
            public DateTime InvoiceDate { get; set; }
        
    }
}