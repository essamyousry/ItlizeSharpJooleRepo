using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole.DAL;
using Joole.Services;
using Joole.UI.Models;

namespace Joole.UI.Controllers
{
    public class ResultsController : Controller
    {
        private readonly ResultsService resultsService;
        private readonly FilterService filterService;
        public ResultsController(ResultsService resultsService, FilterService filterService)
        {
            this.resultsService = resultsService;
            this.filterService = filterService;
        }
        public ActionResult Results()
        { 
            ViewBag.Categories = filterService.GetCategoryNames();
            ViewBag.SubCategories = filterService.GetSubCategoryNames();

            return View();
        }
        public ActionResult SearchResults(string category, string subcategory, string subcategoryid)
        {
            TempData["subid"] = subcategoryid;
            TempData["category"] = category;
            TempData["subcategory"] = subcategory;
            //System.Diagnostics.Debug.WriteLine(subcategoryid);
            //System.Diagnostics.Debug.WriteLine(category);
            //System.Diagnostics.Debug.WriteLine(subcategory);
            var model = new ResultsVM();
            model.SpecList = resultsService.getSpecListForSubCategory(int.Parse(subcategoryid));
            //System.Diagnostics.Debug.WriteLine(model.SpecList.Count);
            return Json(new { url = Url.Action("SS", "Results") });
        }

        public ActionResult SS()
        {
            string subid = TempData["subid"] as string;
            string category = TempData["category"] as string;
            string subcategory = TempData["subcategory"] as string;
            ViewBag.Categories = filterService.GetCategoryNames();
            ViewBag.SpecList = resultsService.getSpecListForSubCategory(int.Parse(subid));
            var model = new ResultsVM();
            model.SpecList = resultsService.getSpecListForSubCategory(int.Parse(subid));
            model.SpecFilterList = resultsService.getSpecFilters(int.Parse(subid));
            model.Category = category;
            model.SubCategory = subcategory;
            return View("Results", model);
        }

        public ActionResult GetSubCategories(string category)
        {
            Category categoryID = filterService.GetCategoryIDFromName(category);
            IEnumerable<SelectListItem> subs = filterService.GetSubs(categoryID.CategoryID);
            return Json(subs, JsonRequestBehavior.AllowGet);
        }

    }
}