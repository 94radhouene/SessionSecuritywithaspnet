using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SessionSecuritywithaspnet.Models
{
    public class Account
    {
        [Display (Name="Username")]
        public string username { get; set; }
        [Display (Name = "Password")]
        public string Password { get; set; }
        public string []Roles { get; set; }
    }
}