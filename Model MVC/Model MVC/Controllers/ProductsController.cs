using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_MVC.Models;
namespace Model_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Class1> produts = new List<Class1>()
            {
                new Class1(){ProductId=101,ProductName="Bikes",ProductRate = 100000 },
                new Class1(){ProductId=102,ProductName="AC",ProductRate = 50000 },
                new Class1(){ProductId=103,ProductName="Mobile",ProductRate = 20000 }
            };
            ViewBag.produts = produts;
            return View();
        }
        public ActionResult Details(int id)
        {
            List<Class1> produts = new List<Class1>()
            {
                new Class1(){ProductId=101,ProductName="Bikes",ProductRate = 100000 },
                new Class1(){ProductId=102,ProductName="AC",ProductRate = 50000 },
                new Class1(){ProductId=103,ProductName="Mobile",ProductRate = 20000 }
            };
            Class1 MatchingProduct = null;
            foreach (var item in produts)
            {
                if(item.ProductId == id)
                {
                    MatchingProduct = item;
                }
            }
            ViewBag.Matchingproducts = MatchingProduct;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Class1 A)
        {
            return View();
        }
    }
}