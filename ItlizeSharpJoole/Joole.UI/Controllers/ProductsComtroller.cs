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
        ResultsService resultsService;
        public ProductController(ProductService productService, ResultsService resultsService)
        {
            this.productService = productService;
            this.resultsService = resultsService;
        }
        public ActionResult ShowProductSummary()
        {
            string prodSummary = Session["ProdSummary"] as string;
            
            string subid = Session["sub"] as string;
            int prodid = int.Parse(prodSummary);

            Product p = productService.GetProduct(prodid);
            Models.CompareVM SummaryData = new Models.CompareVM();
            SummaryData.Products = new List<Product>();
            SummaryData.Products.Add(p);
            SummaryData.Item1 = resultsService.getIndividualPropertiesByProduct(int.Parse(subid), prodid);
            return View("Details", SummaryData);
        }

        public ActionResult getProductID(string prodid)
        {
            Session["ProdSummary"] = prodid;
            return Json(new { url = Url.Action("ShowProductSummary", "Product") });
        }

        public ActionResult ComparisonResults()
        {
            string id1 = Session["id1"] as string;
            string id2 = Session["id2"] as string;
            string subid = Session["sub"] as string;

            Models.CompareVM CompareVM = new Models.CompareVM();
            Product P = productService.GetProduct(int.Parse(id1));
            CompareVM.Products = new List<Product>();
            CompareVM.Products.Add(P);
            CompareVM.Products.Add(productService.GetProduct(int.Parse(id2)));

            CompareVM.Item1 = resultsService.getIndividualPropertiesByProduct(int.Parse(subid), int.Parse(id1));
            CompareVM.Item2 = resultsService.getIndividualPropertiesByProduct(int.Parse(subid), int.Parse(id2));

            return View("Compare", CompareVM);
        }

        public ActionResult Compare(string prod1, string prod2)
        {
            Session["id1"] = prod1;
            Session["id2"] = prod2;
            return Json(new { url = Url.Action("ComparisonResults", "Product") });
        }
    }
}