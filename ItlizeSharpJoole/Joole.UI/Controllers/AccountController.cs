using Joole.DAL;
using Joole.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole.UI.Controllers
{
    public class AccountController : Controller
    {

        JooleDatabaseEntities2 context = new JooleDatabaseEntities2();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            Customer model = new Customer();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("is valid");
                Customer createdCustomer = new Customer();
                createdCustomer.UserID = model.UserID;
                createdCustomer.UserName = model.UserName;
                createdCustomer.UserEmail = model.UserEmail;
                createdCustomer.UserImage = model.UserImage;
                createdCustomer.UserPassword = model.UserPassword;
                context.Customers.Add(createdCustomer);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (context.Customers
                    .Where(m => m.UserEmail == model.EmailOrUsername && m.UserPassword ==
                 model.Password || m.UserName == model.EmailOrUsername && m.UserPassword ==
                 model.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Invalid Email and Password");
                    return View();
                }
                else
                {
                    Session["EmailOrUsername"] = model.EmailOrUsername;
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return View("Login");
        }


    }
}