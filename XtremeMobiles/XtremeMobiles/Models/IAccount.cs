using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeMobiles.Models
{
    public interface IAccount
    {
        void releaseCart(string cust);
        bool addMember(Customer c);
        bool checkUser(string un);
        bool authenticateAdmin(LoginViewModel log);
        Customer authenticateCustomer(LoginViewModel log);
    }
}
