using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole.DAL;
using Joole.Services;

namespace Joole.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilterService filterService;

        public HomeController(FilterService filterService)
        {
            this.filterService = filterService;
        }
        public ActionResult Index()
        {
            Category c = filterService.GetCategory(0);
            //filterService.SaveAll();
            ViewBag.category = c.CategoryName;

            IEnumerable<Category> categories = filterService.GetCategories();
            //filterService.SaveAll();
            ViewBag.categories = categories;

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
    }
}