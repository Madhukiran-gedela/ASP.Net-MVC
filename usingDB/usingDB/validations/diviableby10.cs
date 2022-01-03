using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace usingDB.validations
{
    public class diviableby10 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            double Price = Convert.ToDouble(value);
            if (Price % 10 == 0)
            {
                return ValidationResult.Success;
            }
            else
            {

                return new ValidationResult(this.ErrorMessage);
            }
        }

    }
}