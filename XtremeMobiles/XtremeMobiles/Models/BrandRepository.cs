using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XtremeMobiles.Models;
namespace XtremeMobiles.Models
{
    
    public class BrandRepository:IBrand
    {
        Xtreme db = new Xtreme();
        public List<Product> getNokiaPhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach(var x in list)
            {
                if(x.pId.Equals("Nokia"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getHtcPhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach (var x in list)
            {
                if (x.pId.Equals("Htc"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getHuaweiPhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach (var x in list)
            {
                if (x.pId.Equals("Huawei"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getIPhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach (var x in list)
            {
                if (x.pId.Equals("IPhone"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getLenovoPhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach (var x in list)
            {
                if (x.pId.Equals("Lenovo"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getQMobilePhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach (var x in list)
            {
                if (x.pId.Equals("QMobile"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getSamsungPhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach (var x in list)
            {
                if (x.pId.Equals("Samsung"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getSonyPhones()
        {
            List<Product> list = db.Products.ToList();
            List<Product> list2 = new List<Product>();
            foreach (var x in list)
            {
                if (x.pId.Equals("Sony"))
                {
                    list2.Add(x);
                }
            }
            return list2;
        }
        public List<Product> getLatestProducts()
        {
            try
            {
                return db.Products.Where(z => z.latest.Equals("yes")).ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Specification getSpecifications(string mod)
        {
            try
            {
                return db.Specifications.First(m => m.model.Equals(mod));
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Product getProduct(string mod)
        {
            try
            {
                return db.Products.First(m => m.Model.Equals(mod));
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}