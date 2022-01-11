using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.DataLayer;
using Company.DomainModels;
using usingDB.Fliters;
using Company.ServiceContacts;
using Company.ServiceLayer;
namespace usingDB.Areas.Admin.Controllers
{
    [AdminFliter]
    public class ProductsController : Controller
    {
        CompanyDbContext db;
        IProductService prodService;
        //CompanyDbContext db = new CompanyDbContext();
        public ProductsController(IProductService pService)
        {
            this.db = new CompanyDbContext();
            this.prodService = pService;
            //this.prodService = new ProductServices();
        }
        // GET: Admin/Products
        public ActionResult Index(string search = "", string SortColumn = "ProductID", string IconClass = "fa-sort-asc", int PageNo = 1)
        {
            CompanyDbContext db = new CompanyDbContext();
            ViewBag.search = search;
            //List<Product> products = db.Products.Where(temp => temp.ProductName.Contains(search)).ToList();
            List<Product> products = prodService.SearchProducts(search);
            //sorting
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (ViewBag.SortColumn == "ProductID")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    products = products.OrderBy(temp => temp.ProductID).ToList();
                else
                    products = products.OrderByDescending(temp => temp.ProductID).ToList();
            }
            else if (ViewBag.SortColumn == "ProductName")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    products = products.OrderBy(temp => temp.ProductName).ToList();
                else
                    products = products.OrderByDescending(temp => temp.ProductName).ToList();
            }
            else if (ViewBag.SortColumn == "Price")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    products = products.OrderBy(temp => temp.Price).ToList();
                else
                    products = products.OrderByDescending(temp => temp.Price).ToList();
            }
            else if (ViewBag.SortColumn == "AvailabilityStatus")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    products = products.OrderBy(temp => temp.AvailabilityStatus).ToList();
                else
                    products = products.OrderByDescending(temp => temp.AvailabilityStatus).ToList();
            }
            else if (ViewBag.SortColumn == "BrandID")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    products = products.OrderBy(temp => temp.BrandID).ToList();
                else
                    products = products.OrderByDescending(temp => temp.BrandID).ToList();
            }
            /*paging*/
            int NoOfRecordsPrepage = 5;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(products.Count) / Convert.ToDouble(NoOfRecordsPrepage)));
            int Skip = (PageNo - 1) * NoOfRecordsPrepage;
            ViewBag.PageNo = PageNo;
            ViewBag.NoOfPages = NoOfPages;
            products = products.Skip(Skip).Take(NoOfRecordsPrepage).ToList();
            return View(products);
        }
        public ActionResult Details(long id)
        {
            Product p = prodService.GetProductByProductID(id); 
            //CompanyDbContext db = new CompanyDbContext();
            //Product p = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(p);
        }
        public ActionResult Create()
        {
            CompanyDbContext db = new CompanyDbContext();
            ViewBag.Category = db.Categories.ToList();
            ViewBag.Brands = db.Brands.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Price,DateOfPurchase,AvailabilityStatus,CategoryID,BrandID,Photo")] Product p)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count >= 1)
                {
                    var file = Request.Files[0];
                    var imageBytes = new Byte[file.ContentLength];
                    file.InputStream.Read(imageBytes, 0, file.ContentLength);
                    var base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                    p.Photo = base64String;
                }
                prodService.InsertProduct(p);
                //db.Products.Add(p);
                //db.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                ViewBag.Category = db.Categories.ToList();
                ViewBag.Brands = db.Brands.ToList();
                return View();
            }
        }
        public ActionResult Edit(long id)
        {
            //CompanyDbContext db = new CompanyDbContext();
            //Product p = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            Product p = prodService.GetProductByProductID(id);
            ViewBag.Category = db.Categories.ToList();
            ViewBag.Brands = db.Brands.ToList();
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product E)
        {
            if(ModelState.IsValid)
            {  
            if (Request.Files.Count >= 1)
            {
                var file = Request.Files[0];
                var imageBytes = new Byte[file.ContentLength];
                file.InputStream.Read(imageBytes, 0, file.ContentLength);
                var base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                E.Photo = base64String;
            }
            Product p = db.Products.Where(temp => temp.ProductID == E.ProductID).FirstOrDefault();
            p.ProductName = E.ProductName;
            p.DateOfPurchase = E.DateOfPurchase;
            p.AvailabilityStatus = E.AvailabilityStatus;
            p.BrandID = E.BrandID;
            p.CategoryID = E.CategoryID;
            p.Price = E.Price;
            p.Active = E.Active;
            p.Photo = E.Photo;
                prodService.UpdateProduct(p);
            //db.SaveChanges();
            }
            return RedirectToAction("Index", "Products");
        }
        public ActionResult Delete(long id)
        {

            //Product p = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            Product p = prodService.GetProductByProductID(id);
            return View(p);
        }
        [HttpPost]
        public ActionResult Delete(long id, Product D)
        {
            //Product p = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            //db.Products.Remove(p);
            //db.SaveChanges();
            prodService.DeleteProduct(id);
            return RedirectToAction("Index", "Products");
        }
    }
}