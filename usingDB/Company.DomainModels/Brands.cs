using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Company.DomainModels
{
    public class Brands
    {
        [Key]
        [Display(Name = "Brand")]
        public long BrandID { get; set; }
        [Display(Name = "BrandName")]
        public string BrandName { get; set; }
    }
}
