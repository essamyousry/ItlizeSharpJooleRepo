using Joole.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace Joole.UI.Models
{
    public class ProductVM
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public String Manufacturer { get; set; }
        public int SubCategoryID { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string SeriesInfo { get; set; }

        public ProductVM(int pid, string pn, string mf, int scid, string s, string m, int my, string si)
        {
            ProductID = pid;
            ProductName = pn;
            Manufacturer = mf;
            SubCategoryID = scid;
            Series = s;
            Model = m;
            ModelYear = my;
            SeriesInfo = si;
        }

        public ProductVM()
        {
        }
    }
}