using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Identity;
using usingDB.Fliters;
namespace usingDB.Areas.Admin.Controllers
{
    [AdminFliter]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<ApplicationUser> existingUser = db.Users.ToList();
            return View(existingUser);
        }

        public ActionResult Delete(string id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            ApplicationUserStore use = new ApplicationUserStore(db);
            ApplicationUserManager manager = new ApplicationUserManager(use);
            ApplicationUser users = manager.Users.Where(temp => temp.Id == id).FirstOrDefault();
            var change = manager.Delete(users);
            if (change.Succeeded)
            {
            return RedirectToAction("Index", "Users");
            }
            return View();
        }
    }
}