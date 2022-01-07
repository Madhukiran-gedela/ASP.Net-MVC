using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Fliters;
namespace usingDB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionFilters]
        [ResultFilters]
        [OutputCache(Duration =60)]
        public ActionResult Index()
        {
            throw new Exception("some Expection for testing purpose");
            return View();
        }
    }
}