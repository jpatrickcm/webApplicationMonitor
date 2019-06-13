using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Login
    {
        [Display(Name = "Usuario")]
        public string username { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }
    }
}