using Joole.DAL;
using Joole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace Joole.UI.Models
{
    public class ResultsVM
    {
        public int SubCategoryID { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int Year1 { get; set; }
        public int Year2 { get; set; }
        public List<string> SpecList { get; set; }
        public List<TechSpecFilter> SpecFilterList { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public List<ProductIndividualSpec> IndividualSpecs { get; set; }
        public bool isFiltered { get; set; }

    }
}