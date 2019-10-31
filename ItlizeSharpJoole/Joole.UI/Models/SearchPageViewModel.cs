using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joole.UI.Models
{
    public class SearchPageViewModel
    {
        public IEnumerable<Category> Categories;
        public string Subcategories;
        public int? categoryID;
    }
}