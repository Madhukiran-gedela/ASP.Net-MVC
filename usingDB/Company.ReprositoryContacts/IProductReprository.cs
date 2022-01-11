using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;
namespace Company.ReprositoryContacts
{
    public interface IProductReprository
    {
        List<Product> GetProducts();
        List<Product> SearchProducts(string ProductName);
        Product GetProductByProductID(long ProductID);
        void InsertProduct(Product p);
        void UpdateProduct(Product E);
        void DeleteProduct(long ProductID);


    }
}
