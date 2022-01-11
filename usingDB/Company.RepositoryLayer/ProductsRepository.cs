using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.ReprositoryContacts;
using Company.DomainModels;
using Company.DataLayer;
namespace Company.RepositoryLayer
{
    public class ProductsRepository : IProductReprository
    {
        CompanyDbContext db;
        public ProductsRepository()
        {
            this.db = new CompanyDbContext();
        }
        public List<Product> GetProducts()
        {
            List<Product> products = db.Products.ToList();
            return products;
        }

        public List<Product> SearchProducts(string ProductName)
        {
            List<Product> products = db.Products.Where(temp => temp.ProductName.Contains(ProductName)).ToList();
            return products;
        }
        public Product GetProductByProductID(long ProductID)
        {
            Product p = db.Products.Where(temp => temp.ProductID == ProductID).FirstOrDefault();
            return p;
        }

        public void InsertProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            //List<Product> products = db.Products.ToList();
            //return products;
        }
        public void UpdateProduct(Product E)
        {
            Product p = db.Products.Where(temp => temp.ProductID == E.ProductID).FirstOrDefault();
            p.ProductName = E.ProductName;
            p.DateOfPurchase = E.DateOfPurchase;
            p.AvailabilityStatus = E.AvailabilityStatus;
            p.BrandID = E.BrandID;
            p.CategoryID = E.CategoryID;
            p.Price = E.Price;
            p.Active = E.Active;
            p.Photo = E.Photo;
            db.SaveChanges();
            //List<Product> products = db.Products.ToList();
            //return products;
        }

        public void DeleteProduct(long ProductID)
        {
            Product p = db.Products.Where(temp => temp.ProductID == ProductID).FirstOrDefault();
            db.Products.Remove(p);
            db.SaveChanges();
            //List<Product> products = db.Products.ToList();
            //return products;
        }
    }
}