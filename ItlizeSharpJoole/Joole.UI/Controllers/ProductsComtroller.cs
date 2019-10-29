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
    }
}