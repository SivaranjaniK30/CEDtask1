using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEDtask1.Models;

namespace CEDtask1.Controllers
{
    public class ProductController : Controller
    {
        ProductContext db = new ProductContext();
        public ActionResult Home()
        {
            return View();
        }
        // GET: Product
        public ActionResult ProductAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductAdd(Product p)
        {
           
                db.Products.Add(p);
            if (db.SaveChanges() > 0)
            {
                TempData["msg1"] = "Inserted succesfully!";
                ModelState.Clear();
                return View();
            }
            else
            {
                TempData["msg2"] = "Failed to Insert! Try again";
                return View();
            }


        }

        public ActionResult List()
        {
            return View(db.Products.ToList());
        }
        public ActionResult Details(int id)
        {
                        var prod = db.Products.Where(x => x.Id == id).FirstOrDefault();
                        return View(prod);
        }

        public ActionResult Delete(int id)
        {
           
                db.Products.Remove(db.Products.Where(x=>x.Id ==id).FirstOrDefault());
                db.SaveChanges();
            return RedirectToAction("List","Product");
        }

        public ActionResult Update(int id)
        {
            var prod = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(prod);
        }
        [HttpPost]
        public ActionResult Update(Product p)
        {
            var input = db.Products.Where(x => x.Id == p.Id).FirstOrDefault();
            if (input != null)
            {
                input.Id = p.Id;
                input.Product_Name = p.Product_Name;
                input.Price = p.Price;
                input.Decription = p.Decription;
                input.ProductType = p.ProductType;
                input.isActive = p.isActive;
                db.SaveChanges();
            }

            return RedirectToAction("List","Product");
        }
    }
}