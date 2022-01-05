using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Identity;
namespace usingDB.Areas.Admin.Controllers
{
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
            ApplicationUser users = db.Users.ToList().Where(temp => temp.Id == id).FirstOrDefault();
            db.Users.Remove(users);
            db.SaveChanges();
            return RedirectToAction("Index", "Users");
        }
    }
}