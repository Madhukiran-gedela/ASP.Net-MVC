using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Models;
namespace usingDB.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Brands>Brands = db.Brands.ToList();
            return View(Brands);
        }
    }
}