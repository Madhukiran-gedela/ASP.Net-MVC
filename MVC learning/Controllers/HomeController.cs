using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_learning.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View("OurcompanyProducts");
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Studentdetails()
        {
            ViewBag.StudentId = 221;
            ViewBag.StudentName = "Madhu";
            ViewBag.StudentMarks = 100;
            return View();
        }
        public ActionResult GetEmpName(int EmpId)
        {
            var Employees = new[]
            {
                new {EmpId = 101,EmpName="Madhu",Saraly=10000},
                new {EmpId = 102,EmpName="Kiran",Saraly=30000},
                new {EmpId = 103,EmpName="Raju",Saraly=30000},
            };
            string matchEmpName = null;
            foreach (var item in Employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            return Content(matchEmpName, "text/plain");
        }
        public ActionResult EmpFb(int EmpId)
        {
            var Employees = new[]
            {
                new {EmpId = 101,EmpName="Madhu",Saraly=10000},
                new {EmpId = 102,EmpName="Kiran",Saraly=30000},
                new {EmpId = 103,EmpName="Raju",Saraly=30000},
            };
            string fburl = null;
            foreach (var item in Employees)
            {
                if (item.EmpId == EmpId)
                {

                    fburl = "https://www.google.com/webhp?authuser=1" + EmpId;
                }
            }
            if (fburl == null)
            {
                return Content("invalid emp id ");
            }
            else
            {
                return Redirect(fburl);
            }
        }
    }
}