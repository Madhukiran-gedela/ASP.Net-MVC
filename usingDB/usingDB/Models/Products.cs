﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using usingDB.validations;
namespace usingDB.Models
{
    [Table("Products",Schema ="dbo")]
    public class Product
    {
        [Key]
        [Display(Name = "ProductID")]
        [Required]
        public long ProductID { get; set; }
        [Display(Name = "ProductName")]
        [Required(ErrorMessage ="Please enter the vaild Name")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please enter the vaild Price")]
        [Range(0,100000,ErrorMessage ="price sholud between 0 to 1000")]
        [diviableby10(ErrorMessage ="should be multiple of 10")]
        public Nullable<decimal> Price { get; set; }
        [Display(Name = "DateOfPurchase")]
        [Required(ErrorMessage = "Please enter the Date")]
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        [Display(Name = "AvailabilityStatus")]
        [Required(ErrorMessage = "select the status ")]
        public string AvailabilityStatus { get; set; }
        [Display(Name = "CategoryID")]
        [Required(ErrorMessage = "Please Choose the vaild Category")]
        public Nullable<long> CategoryID { get; set; }

        [Display(Name = "BrandID")]
        [Required(ErrorMessage = "Please choose the Brand")]
        public Nullable<long> BrandID { get; set; }
        [Display(Name = "Active")]
        public Nullable<bool> Active { get; set; }
        [Display(Name = "Photo")]
        public string Photo { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public virtual Brands Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}