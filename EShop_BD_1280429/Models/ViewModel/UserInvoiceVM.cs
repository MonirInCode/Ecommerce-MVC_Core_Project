﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop_BD_1280429.ViewModel
{
    public class UserInvoiceVM
    {
        public int InvoiceId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Bill { get; set; }
        public string Payment { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
    }
}