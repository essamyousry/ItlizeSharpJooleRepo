using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Joole.UI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email or Username required.")]
        public string EmailOrUsername { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}