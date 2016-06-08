using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XtremeMobiles.Models;

namespace XtremeMobiles.Controllers
{
    public class CartController : Controller
    {
        ICart cart;
        public CartController(ICart i)
        {
            cart = i;
        }
        // GET: Cart
        public ActionResult AddToCart(string mod)
        {
            cart.AddToCart(mod , Session["email"]+"");
            return RedirectToAction("ViewCart");
        }
        public ActionResult ViewCart()
        {
            return View(cart.getProductsList());
        }
        public ActionResult Checkout()
        {
            if(cart.checkout(Session["email"]+""))
            {
                ViewBag.cart = "Thank you for shopping here!!!";
            }
            else
            {
                ViewBag.cart = "Please do some shopping before checkout";
            }
            return View();
        }
    }
}