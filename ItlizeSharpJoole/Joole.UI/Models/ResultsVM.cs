using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace Joole.UI.Models
{
    public class ResultsVM
    {
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int Year1 { get; set; }
        public int Year2 { get; set; }
        public IEnumerable<TypeFilter> ProductType { get; set; }
        public List<string> SpecList { get; set; }
        public List<TechSpecFilter> SpecFilterList { get; set; }
    }
}