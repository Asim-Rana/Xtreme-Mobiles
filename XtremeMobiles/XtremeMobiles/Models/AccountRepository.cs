using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XtremeMobiles.Models
{
    public class AccountRepository:IAccount
    {
        Xtreme obj = new Xtreme();
        public bool addMember(Customer c)
        {
            try
            {
                obj.Customers.Add(c);
                obj.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public bool authenticateAdmin(LoginViewModel log)
        {
            try
            {
                var x = obj.Admins.First(z => z.Email.Equals(log.Email) && z.Password.Equals(log.Password));
            }
            catch (Exception)
            {
                
                return false;
            }
            return true;
        }
        public bool checkUser(string un)
        {
            try
            {
                var x = obj.Customers.First(m => m.Email.Equals(un));
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public Customer authenticateCustomer(LoginViewModel log)
        {
            Customer x = new Customer();
            try
            {
                x = obj.Customers.First(z => z.Email.Equals(log.Email) && z.Password.Equals(log.Password));            
            }
            catch (Exception)
            {

                return null;
            }
            return x;
        }
        public void releaseCart(string cust)
        {
            try
            {
                var q = obj.Carts.Where(m => m.cid.Equals(cust)).ToList();
                foreach (var x in q)
                {
                    obj.Carts.Remove(x);
                    obj.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}