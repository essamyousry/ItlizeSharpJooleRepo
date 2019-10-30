using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Joole.DAL;
using Joole.Services;
using Joole.UI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            Session["sub"] = subcategoryid;
            
            var model = new ResultsVM();
            model.SpecList = resultsService.getSpecListForSubCategory(int.Parse(subcategoryid));
            
            return Json(new { url = Url.Action("Result", "Results") });
        }

        public ActionResult Result()
        {
            string subName = Session["subName"] as string;
            int id = -1;
            if (subName == null)
            {
                string sub = Session["sub"] as string;
                id = int.Parse(sub);
                Session["sub"] = sub;
            }
            else
            {
                id = filterService.getSubCatgoryIDFromName(subName);
                Session["sub"] = id.ToString();
            }
            
            string category = filterService.GetCategoryNameFromSub(id);
            string subcategory = filterService.GetSubCateogryName(id);

            ViewBag.Categories = filterService.GetCategoryNames();
            ViewBag.SpecList = resultsService.getSpecListForSubCategory(id);

            var model = new ResultsVM();

            model.SubCategoryID = id;
            model.SpecList = resultsService.getSpecListForSubCategory(id);
            model.SpecFilterList = resultsService.getSpecFilters(id);
            model.Category = category;
            model.SubCategory = subcategory;
            model.Products = resultsService.getAllProductsBySubCategory(id);
            model.IndividualSpecs = resultsService.getIndividualProperties(id);
            model.isFiltered = false;

            return View("Results", model);
        }

        public ActionResult FilterResults()
        {
            string sub = Session["sub"] as string;
            int id = int.Parse(sub);

            string y1 = Session["year1"] as string;
            int year1 = int.Parse(y1);

            string y2 = Session["year2"] as string;
            int year2 = int.Parse(y2);

            string category = filterService.GetCategoryNameFromSub(id);
            string subcategory = filterService.GetSubCateogryName(id);

            ViewBag.Categories = filterService.GetCategoryNames();
            ViewBag.SpecList = resultsService.getSpecListForSubCategory(id);

            var model = new ResultsVM();

            model.SubCategoryID = id;
            model.SpecList = resultsService.getSpecListForSubCategory(id);
            model.SpecFilterList = resultsService.getSpecFilters(id);
            model.Year1 = year1;
            model.Year2 = year2;
            model.Category = category;
            model.SubCategory = subcategory;
            model.Products = resultsService.getAllProductsBySubCategory(id);
            model.IndividualSpecs = resultsService.getIndividualProperties(id);

            List<int> specValues = Session["filterSpecs"] as List<int>;
            ViewBag.filterSpecs = Session["filterSpecs"] as List<int>;

            int i = 0;
            int j = 0;
            while (i < model.SpecList.Count)
            {
                string str1 = model.SpecList[i] + "Min";
                string str2 = model.SpecList[i] + "Max";
                ViewData[str1] = specValues[j].ToString();
                j++;
                ViewData[str2] = specValues[j].ToString();
                j++;

                i++;
            }

            model.isFiltered = true;

            return View("Results", model);
        }

        public ActionResult GetProducts(string year1, string year2, string filter, string subid)
        {
            Session["sub"] = subid;
            if (year1 == "")
                Session["year1"] = "1900";
            else Session["year1"] = year1;

            if (year2 == "")
                Session["year2"] = "2020";
            else Session["year2"] = year2;

            var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(filter);
            //System.Diagnostics.Debug.WriteLine(JSONObj["AirFlow (CFM)"]);
            IDictionaryEnumerator myEnumerator =
                     JSONObj.GetEnumerator();

            List<int> arrayList = new List<int>();

            while (myEnumerator.MoveNext())
            {
                //arrayList.Add(myEnumerator.Key.ToString());
                String[] str = myEnumerator.Value.ToString().Split('-');
                arrayList.Add(int.Parse(str[0]));
                arrayList.Add(int.Parse(str[1]));
            }
            for (int i = 0; i < arrayList.Count; i++)
                System.Diagnostics.Debug.WriteLine(arrayList[i]);
            Session["filterSpecs"] = arrayList;

            return Json(new { url = Url.Action("FilterResults", "Results") });
        }

        public ActionResult GetSubCategories(string category)
        {
            Category categoryID = filterService.GetCategoryIDFromName(category);
            IEnumerable<SelectListItem> subs = filterService.GetSubs(categoryID.CategoryID);
            return Json(subs, JsonRequestBehavior.AllowGet);
        }

    }
}