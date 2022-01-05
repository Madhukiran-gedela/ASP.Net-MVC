using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using usingDB.Models;
using usingDB.viewmodel;
using usingDB.Identity;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace usingDB.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        //post:Account
        [HttpPost]
        public ActionResult Register(Registionviewmodel rvm)
        {
            if (ModelState.IsValid)
            {
                //register
                var appDbcontext = new ApplicationDbContext();
                var userStore = new ApplicationUserStore(appDbcontext);
                var userManager = new ApplicationUserManager(userStore);
                var passwordHash = Crypto.HashPassword(rvm.Password);
                var user = new ApplicationUser() { Email = rvm.Email, UserName = rvm.Username, PasswordHash = passwordHash, PhoneNumber = rvm.MobileNumber, Birthday = rvm.DateofBirth };
                IdentityResult result = userManager.Create(user);
                if (result.Succeeded)
                {
                    //role
                    userManager.AddToRole(user.Id, "Employee");
                    //login
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("My Error", "Invaild data");
                return View();
            }
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        //post:Account
        [HttpPost]
        public ActionResult Login(Loginform lvm)
        {
                //Login
                var appDbcontext = new ApplicationDbContext();
                var userStore = new ApplicationUserStore(appDbcontext);
                var userManager = new ApplicationUserManager(userStore);
                var user = userManager.Find(lvm.Username, lvm.Password);
                if (user != null)
                {
                //login
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                if (userManager.IsInRole(user.Id,"Admin"))
                {

                    return RedirectToAction("Index", "Home",new { area = "Admin" });
                }
                else if (userManager.IsInRole(user.Id,"Manager"))
                {
                    return RedirectToAction("Index", "Home", new { area = "Manager" });
                }
                else
                {

                    return RedirectToAction("Index", "Home"); 
                }
                }
                else
                {
                    ModelState.AddModelError("myerror", "invalid username or password");
            return View();
                }
        }
        //GET : LogOut
        public ActionResult logout()
        {
            var authenticationManager = HttpContext.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //Get : Myprofile
        public ActionResult MyProfile()
        {
            var appDbcontext = new ApplicationDbContext();
            var userStore = new ApplicationUserStore(appDbcontext);
            var userManager = new ApplicationUserManager(userStore);
            ApplicationUser appUser = userManager.FindById(User.Identity.GetUserId());
            return View(appUser);
        }

    }
}