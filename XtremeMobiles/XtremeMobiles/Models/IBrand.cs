using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremeMobiles.Models
{
    public interface IBrand
    {
        List<Product> getNokiaPhones();
        List<Product> getHtcPhones();
        List<Product> getHuaweiPhones();
        List<Product> getIPhones();
        List<Product> getLenovoPhones();
        List<Product> getQMobilePhones();
        List<Product> getSamsungPhones();
        List<Product> getSonyPhones();
        List<Product> getLatestProducts();
        Specification getSpecifications(string mod);
        Product getProduct(string mod);

       
    }
}
