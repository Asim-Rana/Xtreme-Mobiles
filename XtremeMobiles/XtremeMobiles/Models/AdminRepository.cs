using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XtremeMobiles.Models;
namespace XtremeMobiles.Models
{
    public class AdminRepository:IAdmin
    {
        Xtreme obj = new Xtreme();
        public bool addProduct(Product p, Specification s)
        {

            try
            {
                obj.Products.Add(p);
                obj.Specifications.Add(s);
                obj.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public List<Product> getAllProducts()
        {
            return obj.Products.ToList();     
        }
        
        public Product getProduct(string model)
        {
            //return obj.Products.Find(model);
            return obj.Products.First(z => z.Model.Equals(model));
        }
        public void deleteProduct(string model)
        {
            var x = obj.Products.First(z => z.Model.Equals(model));
            var y = obj.Specifications.First(w => w.model.Equals(model));
            obj.Products.Remove(x);
            obj.Specifications.Remove(y);
            obj.SaveChanges();
        }
        
        public void updateProductToDb(string model , int p , string l)
        {
            var x = obj.Products.Find(model);
            x.Price = p;
            x.latest = l;
            obj.SaveChanges();
        }
        public List<Customer> getAllMembers()
        {
            return obj.Customers.ToList(); 
        }
        public List<Order> getAllOrders()
        {
            return obj.Orders.ToList(); 
        }
        public void deleteOrder(int id)
        {
            var x = obj.Orders.Find(id);
            obj.Orders.Remove(x);
            obj.SaveChanges();
        }
        //public List<Category> getAllBrands()
        //{
        //    return obj.Categories.ToList(); 
        //}
    }
}