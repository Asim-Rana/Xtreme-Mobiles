using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XtremeMobiles.Models;

namespace XtremeMobiles.Controllers
{
    public class AdminController : Controller
    {
        
        IAdmin repo;
        public AdminController(IAdmin a)
        {
            repo = a;
        }
        // GET: Admin
        public ActionResult Main()
        {
            return View();
        }
        //public ActionResult Account()
        //{
        //    return View();
        //}
        public ActionResult Logout()
        {
            return RedirectToAction("Index" , "Home");
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        public ActionResult viewProducts()
        {
            return View(repo.getAllProducts());
        }
        public ActionResult viewMembers()
        {
            return View(repo.getAllMembers());
        }
        public ActionResult viewOrders()
        {
            return View(repo.getAllOrders());
        }
        public ActionResult AddBrand()
        {
            return View();
        }
        public ActionResult UpdateAndDelete()
        {
            return View(repo.getAllProducts());
        }
        public ActionResult UpdateProduct(string Mod)
        {
             var x = repo.getProduct(Mod);
             return View(x);
        }
        [HttpPost]
        public ActionResult UpdateProductDb(string Mod)
        {
            int p = Int32.Parse(Request["t1"]);
            string l = Request["lat"];
            repo.updateProductToDb(Mod , p , l);
            return RedirectToAction("UpdateAndDelete");
        }
        
        public ActionResult DeleteProduct(string Mod)
        {
            repo.deleteProduct(Mod);
            return RedirectToAction("UpdateAndDelete");
        }
        //public ActionResult UpdateAndDeleteBrand()
        //{
        //    return View(repo.getAllBrands());
        //}
        [HttpPost]
        public ActionResult AddProductToDb(Category c , Product p , Specification s)
        {
            HttpPostedFileBase file = Request.Files["image"];

            string ImageName = System.IO.Path.GetFileName(file.FileName);
            
            string physicalPath = Server.MapPath("/img/" + ImageName);

            // save image in folder
            p.Image = "/img/" + ImageName;
            p.pId = c.Name;
            s.model = p.Model;
            file.SaveAs(physicalPath);
            if(repo.addProduct(p , s))
            {
                ViewBag.message = "Successfully Added";
            }
            else
            {
                ViewBag.message = "Not Added Successfully";
            }
            return RedirectToAction("AddProduct");
        }
        public ActionResult deleteOrder(int id)
        {
            repo.deleteOrder(id);
            return RedirectToAction("viewOrders");
        }
        //[HttpPost]
        //public ActionResult AddBrandToDb(Category c)
        //{
        //    Xtreme obj = new Xtreme();
        //    obj.Categories.Add(c);
            
        //    obj.SaveChanges();
        //    return RedirectToAction("AddBrand");
        //}
    }
}