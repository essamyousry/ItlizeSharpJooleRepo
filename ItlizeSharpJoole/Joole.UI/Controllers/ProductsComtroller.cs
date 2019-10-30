using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joole.DAL;
using Joole.Services;
using Joole.UI.Models;

namespace Joole.UI.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService;
        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }
        public ActionResult ShowProductSummary(int itemid)
        {
            Product p = productService.GetProduct(itemid);
            Models.ProductVM SummaryData = new Models.ProductVM();
            SummaryData.ProductID = p.ProductID;
            SummaryData.ProductName = p.ProductName;
            SummaryData.Manufacturer = p.Manufacturer;
            SummaryData.SubCategoryID = p.SubCategoryID;
            SummaryData.Series = p.Series;
            SummaryData.Model = p.Model;
            SummaryData.ModelYear = (int)p.ModelYear;
            return View(SummaryData);
        }

        public ActionResult ComparisonResults()
        {
            string id1 = Session["id1"] as string;
            string id2 = Session["id2"] as string;

            Models.CompareVM CompareVM = new Models.CompareVM();
            CompareVM.Proudcts.Add(productService.GetProduct(int.Parse(id1)));
            CompareVM.Proudcts.Add(productService.GetProduct(int.Parse(id2)));

            return View("Compare", CompareVM);
        }

        public ActionResult Compare(string id1, string id2)
        {
            Session["id1"] = id1;
            Session["id2"] = id2;
            return Json(new { url = Url.Action("ComparisonResults", "Product") });
        }
    }
}