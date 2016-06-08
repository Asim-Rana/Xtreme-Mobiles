using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XtremeMobiles.Models
{
    public class CartRepository:ICart
    {
        Xtreme db = new Xtreme();
        public void AddToCart(string mod, string id)
        {
            try
            {
                var q = db.Carts.First(m => m.pid.Equals(mod));
                q.quantity++;
                db.SaveChanges();
            }
            catch (Exception)
            {
                Cart c = new Cart();
                c.cid = id;
                c.pid = mod;
                c.quantity = 1;
                db.Carts.Add(c);
                db.SaveChanges();
            }
            
        }
        public List<Cart> getProductsList()
        {
            try
            {
                return db.Carts.ToList();
                
            }
            catch (Exception)
            {
                
                return null;
            }
        }
        public bool checkout(string cust)
        {
            bool flag = false;
            try
            {
                var q = db.Carts.Where(m => m.cid.Equals(cust)).ToList();
                foreach (var x in q)
                {
                    Order o = new Order();
                    o.cid = x.cid;
                    o.quantity = x.quantity;
                    o.pid = x.pid;
                    o.date = DateTime.Now + "";
                    db.Orders.Add(o);
                    db.Carts.Remove(x);
                    db.SaveChanges();
                    flag = true;
                }
                
            }
            catch (Exception)
            {
                
            }
            return flag;
        }
    }
}