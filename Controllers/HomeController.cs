using ERestaurantsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERestaurantsMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
      
        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Booking()
        {
            return View();
        }

        public ActionResult Registartion()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registartion(TblUser r1)
        {
            using (ERestDataEntities db = new ERestDataEntities())
            {
                if (ModelState.IsValid)
                {
                    db.TblUsers.Add(r1);
                    db.SaveChanges();
                    ViewBag.message("Registration Sucessfully");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }
        [HttpPost]
        public ActionResult Login(TblUser r1)
        {
            using (ERestDataEntities db = new ERestDataEntities())
            {
                if (ModelState.IsValid)
                {
                    var log = db.TblUsers.Where(a => a.userName.Equals(r1.userName) && a.password.Equals(r1.password)).FirstOrDefault();
                    if (log != null)
                    {
                        return RedirectToAction("Order");
                    }

                    ViewBag.message("Login Sucessfully");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }
    }
}