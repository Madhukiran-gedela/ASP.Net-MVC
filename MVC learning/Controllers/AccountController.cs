using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_learning.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string Username,string Password)
        {
            if (Username == "admin" && Password == "man")
                return RedirectToAction("Dashboard", "admin");
            else
                return RedirectToAction("Invalid Login");
        }
        public ActionResult IvalidLogin()
        {
            return View();
        }
    }
}