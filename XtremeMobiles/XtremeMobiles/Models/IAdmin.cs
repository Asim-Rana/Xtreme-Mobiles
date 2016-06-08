using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeMobiles.Models
{
    public interface IAdmin
    {
        bool addProduct(Product p, Specification s);
        List<Product> getAllProducts();
        
        Product getProduct(string model);
        void deleteProduct(string model);
        void updateProductToDb(string model , int p , string l);
        List<Customer> getAllMembers();
        List<Order> getAllOrders();
        void deleteOrder(int id);
        //List<Category> getAllBrands();
    }
}
