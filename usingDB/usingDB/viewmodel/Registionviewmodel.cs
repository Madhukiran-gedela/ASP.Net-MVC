using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace usingDB.viewmodel
{
    public class Registionviewmodel
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Please enter your mail")]
        [EmailAddress(ErrorMessage ="Invaild email")]
        public string  Email{ get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage =  "Password does not Match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter your dob")]
        public DateTime? DateofBirth { get; set; }
        [Required(ErrorMessage = "Please enter vaild dob")]
        public string MobileNumber { get; set; }
    }
}