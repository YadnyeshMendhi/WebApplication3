using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication3.CustomValidations
public class DivivsibleBy10Attribute : ValidationAttribute
{
    protected override ValidationResult Isvalid(object value, ValidationContext validationContext)
    {
        double price = Convert.ToDouble(value);
        if (price % 10 == 0)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult(this.ErrorMessage);
        }
    }
}
