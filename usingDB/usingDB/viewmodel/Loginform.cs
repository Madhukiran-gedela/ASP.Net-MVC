using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace usingDB.viewmodel
{
    public class Loginform
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "please enter a password")]
        public string Password { get; set; }
    }
}