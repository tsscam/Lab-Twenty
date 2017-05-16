using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTwenty.Models;

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
        public ActionResult AddUser(UserInfo NewUser)
        {
            // VALIDATION ! //
            //USED TO CALL/ADD DATA FROM THE MODEL to the DATABASE//

            return View(NewUser);//pass this NewUser model to the AddUser View     

            //code to get user information
            //string fName = FirstName;
            //ViewBag.FirstName = "Your registered " + fName;

            ////string pass1 = "";
            ////Console.Write(pass1.PadLeft(5, '*'));
        }
        public ActionResult Admin()
        {
            ViewBag.Message = "Administration";

            CoffeeShopDBEntities CS = new CoffeeShopDBEntities();

            //select * from customers
            List<Item> ItemList = CS.Items.ToList();

            ViewBag.ItemList = ItemList;

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult AddNewItem(Item NewItem)
        {
            CoffeeShopDBEntities CS = new CoffeeShopDBEntities();

            CS.Items.Add(NewItem);

            CS.SaveChanges();

            return RedirectToAction("Admin");
        }

        public ActionResult Delete(string Name)
        {
            CoffeeShopDBEntities CS = new CoffeeShopDBEntities();

            //step #1 "find the custoemr that I need to delete....//
            Item ToDelete = CS.Items.Find(Name);

            if (ToDelete == null)
            {
                ViewBag.ErrorMessage = "Unavailable";
                return View("ErrorMessage");
            }

            //removes OBJECTS from DATABASE

            CS.Items.Remove(ToDelete);

            //to SAVE EVERYTHING TO DATABASE.....
            CS.SaveChanges();

            return RedirectToAction("Admin");
        }
        public ActionResult Update(string Name)
        {
            //first thing...TO SHOW DATA

            CoffeeShopDBEntities CS = new CoffeeShopDBEntities();

            //update will SHOW up & THE MODEL will be updated......
            Item ToFind = CS.Items.Find(Name);

            return View("Edit", ToFind);
        }


        public ActionResult SaveUpdates(Item ToBeUpdated)
        {
            CoffeeShopDBEntities CS = new CoffeeShopDBEntities();
        //find the original customer record
        Item ToFind = CS.Items.Find(ToBeUpdated);

            ToFind.Name = ToBeUpdated.Name;

            ToFind.Description = ToBeUpdated.Description;

            ToFind.Quantity = ToBeUpdated.Quantity;

            ToFind.Price = ToBeUpdated.Price;

            CS.SaveChanges();
            return RedirectToAction("Admin");

    }


}
}