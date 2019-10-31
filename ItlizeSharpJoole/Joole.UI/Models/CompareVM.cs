using Joole.DAL;
using Joole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace Joole.UI.Models
{
    public class CompareVM
    {
        public List<Product> Products { get; set; }
        public List<ProductIndividualSpec> Item1 { get; set; }
        public List<ProductIndividualSpec> Item2 { get; set; }
    }
}