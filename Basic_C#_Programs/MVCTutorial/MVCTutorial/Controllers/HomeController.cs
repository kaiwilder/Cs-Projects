using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\kaiwi\OneDrive\Documents\GitHub\Cs-Projects\Basic_C#_Programs\log.txt", text);

            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};

            //int number = 5;

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}