using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HTTPController : Controller
    {
        // GET: HTTP
        public ActionResult Index()
        {
            return View();
        }

        //SHARED VIEWS
        public ActionResult Contact()
        {
            ViewBag.Message = "This is HTTP Contact Page.";

            return View();
        }

        //REQUEST OBJECTS
        public ActionResult HTTPRequest()
        {
            ViewBag.URL = Request.Url;
            ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
            ViewBag.Path = Request.Path;
            ViewBag.BrowserType = Request.Browser;
            ViewBag.Headers = Request.Headers;
            ViewBag.queryString = Request.QueryString;
            ViewBag.Method = Request.HttpMethod;
            return View();
        }

        //RESPONSE OBJECT
        public ActionResult HTTPResponse()
        {
            Response.Write("Welcome to systems plus family !!");
            return View();
        }

    }
}