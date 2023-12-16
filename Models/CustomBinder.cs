using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class CustomBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int ID = Convert.ToInt32(controllerContext.HttpContext.Request.Form["StudentID"]);
            string Name = (controllerContext.HttpContext.Request.Form["StudentName"]);
            string City = (controllerContext.HttpContext.Request.Form["City"]);

            return new Student() { StudentID = ID, StudentName = Name, City = City };
        }
    }
}