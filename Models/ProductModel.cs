using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.CustomValidations;


namespace WebApplication3.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        
        [Display(Name = "Product Name")]
        [Required(ErrorMessage ="This is mandetory field")]
        public string ProductName { get; set; }

        [Display(Name = "Product Rate")]
        [Required(ErrorMessage = "This is mandetory field")]
        [DivivsibleBy10Attribute(ErrorMessage = "Price Should be Multiples 10")]
        [RegularExpression(@"^[A-Za-z ]*$" , ErrorMessage ="Alphabets only")]
        public double Rate { get; set; }
    }
}