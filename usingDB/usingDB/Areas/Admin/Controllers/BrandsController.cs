using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Models;
using usingDB.Fliters;
namespace usingDB.Areas.Admin.Controllers
{
    [AdminFliter]
    public class BrandsController : Controller
    {
        // GET: Admin/Brands
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Brands> Brands = db.Brands.ToList();
            return View(Brands);
        }
    }
}