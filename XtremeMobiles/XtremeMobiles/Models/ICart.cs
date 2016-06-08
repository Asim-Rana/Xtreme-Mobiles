using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeMobiles.Models
{
    public interface ICart
    {
        void AddToCart(string mod , string id);
        List<Cart> getProductsList();
        bool checkout(string cust);
    }
}
