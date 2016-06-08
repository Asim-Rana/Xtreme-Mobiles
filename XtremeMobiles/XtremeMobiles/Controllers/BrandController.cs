using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XtremeMobiles.Models;

namespace XtremeMobiles.Controllers
{
    public class BrandController : Controller
    {
        IBrand brand;
        public BrandController(IBrand b)
        {
            brand = b;
        }
        public ActionResult Nokia()
        {
            ViewBag.Message = "Nokia Phones.";

            return View(brand.getNokiaPhones());
        }
        public ActionResult HTC()
        {
            ViewBag.Message = "HTC Phones.";

            return View(brand.getHtcPhones());
        }
        public ActionResult QMobile()
        {
            ViewBag.Message = "QMobile.";

            return View(brand.getQMobilePhones());
        }
        public ActionResult Huawei()
        {
            ViewBag.Message = "Huawei Phones.";

            return View(brand.getHuaweiPhones());
        }
        public ActionResult Samsung()
        {
            ViewBag.Message = "Samsung Phones.";

            return View(brand.getSamsungPhones());
        }
        public ActionResult iPhone()
        {
            ViewBag.Message = "iPhones.";

            return View(brand.getIPhones());
        }
        public ActionResult Sony()
        {
            ViewBag.Message = "Sony Phones.";

            return View(brand.getSonyPhones());
        }
        public ActionResult Lenovo()
        {
            ViewBag.Message = "Lenovo Phones.";

            return View(brand.getLenovoPhones());
        }

        public ActionResult Specifications(string mod)
        {
            Product p = brand.getProduct(mod);
            Specification s = brand.getSpecifications(mod);
            ViewBag.product = p;
            ViewBag.specs = s;
            return View();
        }
        
        public JsonResult getByPrice(string p1 , string p2)
        {
            Xtreme db = new Xtreme();
            int i = Int32.Parse(p1);
            int j = Int32.Parse(p2);
            
            return this.Json(
                     (from obj in db.Products
                      where obj.Price >= i && obj.Price <= j
                      select new { Model = obj.Model , Price = obj.Price, pId = obj.pId })

                     , JsonRequestBehavior.AllowGet
                  );
        }
    }
}