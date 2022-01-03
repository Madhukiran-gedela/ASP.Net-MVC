using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.ComponentModel.DataAnnotations;
namespace usingDB.Models
{
    public class Brands
    {
        [Key]
        [Display(Name ="Brand")]
        public long BrandID { get; set; }
        [Display(Name = "BrandName")]
        public string BrandName { get; set; }
    }
}