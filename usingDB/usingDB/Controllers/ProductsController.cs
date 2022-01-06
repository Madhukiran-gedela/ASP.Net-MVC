using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Models;
using usingDB.Fliters;
namespace usingDB.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        [MyAuthenticationFilters]
        [Custmoerfliter]
        [ActionFilters]
        [MyExpectionFliter]
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Product> products = db.Products.ToList();
            return View(products);
        }
        [ChildActionOnly]
        public ActionResult DisplaySingleProduct(Product p)
        {
            return PartialView("MyProduct",p);
        }
    }
}