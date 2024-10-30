using EShop_BD_1280429.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop_BD_1280429.Controllers
{
    public class ProductsController : Controller
    {
        AppDbContext db = new AppDbContext();



        public ActionResult Index()
        {
            var query = db.Products.ToList();
            return View(query);
        }



        public ActionResult Create()
        {
            List<Category> list = db.Categories.ToList();
            ViewBag.CatList = new SelectList(list, "CategoryId", "Name");
            return View();
        }



        [HttpPost]
        public ActionResult Create(Product p, HttpPostedFileBase Image)
        {
            List<Category> list = db.Categories.ToList();
            ViewBag.CatList = new SelectList(list, "CategoryId", "Name");


            if (ModelState.IsValid)
            {


                Product pro = new Product();
                pro.Name = p.Name;
                pro.Description = p.Description;
                pro.Unit = p.Unit;
                pro.Image = Image.FileName.ToString();
                pro.CategoryId = p.CategoryId;

                //image upload
                var folder = Server.MapPath("~/Uploads/");
                Image.SaveAs(Path.Combine(folder, Image.FileName.ToString()));

                db.Products.Add(pro);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                TempData["msg"] = "Product Not Upload";
            }
            return View();
        }




        public ActionResult Edit(int id)
        {

            List<Category> list = db.Categories.ToList();
            ViewBag.CatList = new SelectList(list, "CategoryId", "Name");

            var query = db.Products.SingleOrDefault(m => m.ProductId == id);

            return View(query);
        }


        [HttpPost]
        public ActionResult Edit(Product p, HttpPostedFileBase Image)
        {
            List<Category> list = db.Categories.ToList();
            ViewBag.CatList = new SelectList(list, "CategoryId", "Name", p.CategoryId);

            if (ModelState.IsValid)
            {
                Product product = db.Products.Find(p.ProductId);
                if (product == null)
                {
                    return HttpNotFound();
                }

                product.Name = p.Name;
                product.Description = p.Description;
                product.Unit = p.Unit;
                product.CategoryId = p.CategoryId;

                if (Image != null)
                {
                    // Update image only if a new image is provided
                    product.Image = Image.FileName.ToString();

                    // image upload
                    var folder = Server.MapPath("~/Uploads/");
                    Image.SaveAs(Path.Combine(folder, Image.FileName.ToString()));
                }

                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                TempData["msg"] = "Product Not Updated";
            }
            return View(p);
        }




        public ActionResult Delete(int id)
        {
            var query = db.Products.SingleOrDefault(m => m.ProductId == id);
            db.Products.Remove(query);

            db.SaveChanges();


            return RedirectToAction("Index");

        }
        public ActionResult AllProduct(string searchQuery, string sortOrder, int? page, int? categoryId)
        {
            if (TempData["cart"] != null)
            {
                int x = 0;
                List<Cart> cartItems = TempData["cart"] as List<Cart>;
                foreach (var item in cartItems)
                {
                    x += item.bill;
                }
                TempData["total"] = x;
                TempData["item_count"] = cartItems.Count();
            }
            TempData.Keep();

            var products = db.Products.AsQueryable();

            // Apply search query filter if provided
            if (!string.IsNullOrEmpty(searchQuery))
            {
                products = products.Where(p => p.Name.Contains(searchQuery));
            }

            // Apply category filter if provided
            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            ViewBag.Categories = db.Categories.ToList();
            ViewBag.SelectedCategory = categoryId;

            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.PriceSortParam = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";
            ViewBag.NameAscSortParam = String.IsNullOrEmpty(sortOrder) ? "name_asc" : "";
            ViewBag.PriceAscSortParam = String.IsNullOrEmpty(sortOrder) ? "price_asc" : "";

            // Apply sorting based on sortBy and sortOrder parameters
            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(c => c.Name);
                    break;
                case "name_asc":
                    products = products.OrderBy(c => c.Name);
                    break;
                
                
                
                default:
                    products = products.OrderBy(c => c.ProductId);
                    break;
            }

            int pageSize = 6;
            int pageNumber = (page ?? 1);

            var pagedProducts = products.ToPagedList(pageNumber, pageSize);

            return View(pagedProducts);
        }


        public ActionResult ProductsByCategory(int? categoryId)
        {
            if (categoryId == null)
            {
                return RedirectToAction("AllProduct");
            }

            return RedirectToAction("AllProduct", new { categoryId });
        }


    }
}