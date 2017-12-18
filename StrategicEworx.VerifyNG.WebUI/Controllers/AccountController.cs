using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StrategicEworx.VerifyNG.DAL.Data;
using StrategicEworx.VerifyNG.Models;

namespace StrategicEworx.VerifyNG.WebUI.Controllers.VerifyNG
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (AppDataContext db = new AppDataContext())
            {
                return View(db.User.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User account)
        {
            if (ModelState.IsValid)
            {
                using(AppDataContext db = new AppDataContext())
                {
                    db.User.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " successfully registered";  
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            using(AppDataContext db = new AppDataContext())
            {
                var usr = db.User.Single(u => u.TelephoneNumber == user.TelephoneNumber && u.DateOfBirth == user.DateOfBirth);
                if(usr != null)
                {
                    Session["id"] = usr.id.ToString();
                    Session["TelephoneNumber"] = usr.TelephoneNumber.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Telephone Number or Date of Birth is wrong! ");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if(Session["id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}