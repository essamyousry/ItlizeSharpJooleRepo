using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Joole.UI.Models
{
    public class CustomerViewModel
    {
        [Required(ErrorMessage = "UserID is required")]
        [Display(Name = "UserID: ")]
        public int UserID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "UserName is required")]
        [Display(Name = "UserName: ")]
        public string UserName { get; set; }

        [Display(Name = "UserEmail: ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "UserEmail is required")]
        public string UserEmail { get; set; }
        [Display(Name = "UserImage: ")]
        public string UserImage { get; set; }

        [Display(Name = "UserPassword: ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "UserPassword is required")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}