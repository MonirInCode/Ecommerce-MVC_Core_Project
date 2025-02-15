﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop_BD_1280429.Models
{
    public class User
    {
        public User()
        {
            this.Invoices = new HashSet<Invoice>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleType { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}