using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop_BD_1280429.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}