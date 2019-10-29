using Joole.DAL;
using Joole.Repo;
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
        private readonly UnitOfWork _UoW;
        private readonly CustomerRepo _CustomerRepo;

        public AccountController(IUnitOfWork unitOfWork, ICustomerRepo customerRepo)
        {
            this._UoW = unitOfWork as UnitOfWork;
            this._CustomerRepo = customerRepo as CustomerRepo;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            CustomerViewModel model = new CustomerViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(CustomerViewModel model)
        {
            JooleDatabaseEntities2 context = new JooleDatabaseEntities2();
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
                if (_UoW.customerRepo.GetAllCustomer()
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