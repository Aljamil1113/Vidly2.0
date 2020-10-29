using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly2_0.Models.CustomValidation
{
    public class LimitValue : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.Stocks <= 0 || movie.Stocks > 20)
            {
                return new ValidationResult("Stocks must between 0 to 20");
            }
            return ValidationResult.Success;
        }
    }
}