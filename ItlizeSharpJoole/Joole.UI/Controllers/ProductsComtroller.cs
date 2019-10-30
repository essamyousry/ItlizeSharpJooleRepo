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
    public class ProductController : Controller
    {
        ProductService productService;
        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }
        public ActionResult ShowProductSummary()
        {
            string prodSummary = Session["ProdSummary"] as string;
            int prodid = int.Parse(prodSummary);

            Product p = productService.GetProduct(prodid);
            Models.ProductVM SummaryData = new Models.ProductVM();

            SummaryData.ProductID = p.ProductID;
            SummaryData.ProductName = p.ProductName;
            SummaryData.Manufacturer = p.Manufacturer;
            SummaryData.SubCategoryID = p.SubCategoryID;
            SummaryData.Series = p.Series;
            SummaryData.Modelm = p.Model;
            SummaryData.ModelYear = (int)p.ModelYear;

            return View("Details", SummaryData);
        }

        public ActionResult getProductID(string prodid)
        {
            Session["ProdSummary"] = prodid;
            return Json(new { url = Url.Action("ShowProductSummary", "Product") });
        }
    }
}