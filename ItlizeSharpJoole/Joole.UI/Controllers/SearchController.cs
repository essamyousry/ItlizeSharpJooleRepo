using Joole.DAL;
using Joole.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Joole.UI.Controllers
{
    public class SearchController : Controller
    {

        JooleDatabaseEntities2 context = new JooleDatabaseEntities2();
        public ActionResult Index(int? id)
        {

            SearchPageViewModel model = new SearchPageViewModel
            {
                Categories = context.Categories,
                categoryID = id
            };
            string subcnames = "";
            if (id == null)
            {
                foreach (var item in context.SubCategories)
                    subcnames += item.SubCategoryName + " ";
            }
            else
            {
                foreach (var item in context.SubCategories.Where(sb => sb.CategoryID == id))
                    subcnames += item.SubCategoryName + " ";
            }
            model.Subcategories = subcnames;
            return View(model);
        }

        public ActionResult ToResult(string subName)
        {
            Session["subName"] = subName;
            return Json(new { url = Url.Action("Result", "Results") });
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