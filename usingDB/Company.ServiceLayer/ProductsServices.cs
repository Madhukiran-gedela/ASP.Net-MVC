using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.ServiceContacts;
using Company.DataLayer;
using Company.DomainModels;
using Company.RepositoryLayer;
using Company.ReprositoryContacts;
namespace Company.ServiceLayer
{
    public class ProductServices : IProductService
    {
        CompanyDbContext db;
        IProductReprository prodRep;
        //CompanyDbContext db;
        public ProductServices(IProductReprository r)
        {
            this.prodRep = r;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = prodRep.GetProducts();
            return products;
        }

        public List<Product> SearchProducts(string ProductName)
        {
            List<Product> products = prodRep.SearchProducts(ProductName);
            return products;
        }
        public Product GetProductByProductID(long ProductID)
        {
            Product p = prodRep.GetProductByProductID(ProductID);
            return p;
        }

        public void InsertProduct(Product p)
        {
            if (p.Price <= 1000000)
            {
            prodRep.InsertProduct(p);
            }
            else
            {
                throw new Exception("price exceeds the limit");
            }
            //db.Products.Add(p);
            //db.SaveChanges();
            //List<Product> products = db.Products.ToList();
            //return products;
        }
        public void UpdateProduct(Product E)
        {
            prodRep.UpdateProduct(E);
            //Product p = db.Products.Where(temp => temp.ProductID == E.ProductID).FirstOrDefault();
            //p.ProductName = E.ProductName;
            //p.DateOfPurchase = E.DateOfPurchase;
            //p.AvailabilityStatus = E.AvailabilityStatus;
            //p.BrandID = E.BrandID;
            //p.CategoryID = E.CategoryID;
            //p.Price = E.Price;
            //p.Active = E.Active;
            //p.Photo = E.Photo;
            //db.SaveChanges();
            ////List<Product> products = db.Products.ToList();
            ////return products;
        }

        public void DeleteProduct(long ProductID)
        {
            prodRep.DeleteProduct(ProductID);
            //Product p = db.Products.Where(temp => temp.ProductID == ProductID).FirstOrDefault();
            //db.Products.Remove(p);
            //db.SaveChanges();
            ////List<Product> products = db.Products.ToList();
            ////return products;
        }
    }
}