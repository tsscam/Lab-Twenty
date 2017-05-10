using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTwenty.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Welcome to GC COFFEE!";
            return View();
        }
        public ActionResult AddUser(string FirstName, string LastName, string Email, string Phone, string Password)
        {
            string fName = FirstName;
            ViewBag.FirstName = "Your registered" + "" + fName;

            //string pass1 = "";
            //Console.Write(pass1.PadLeft(5, '*'));
            

            return View();
            

            

            //code to get user information
        }
            

    }
}