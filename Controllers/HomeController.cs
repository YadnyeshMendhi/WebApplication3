using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ProductModel> Products = new List<ProductModel>()
            {
                new ProductModel(){ ProductID=101, ProductName="Redmi Note 12 Pro", Rate=50000 },
                new ProductModel(){ ProductID=102, ProductName="Redmi Note 11 Pro", Rate=20000 },
                new ProductModel(){ ProductID=103, ProductName="Redmi Note 10 Pro", Rate=15000 },
            };

            ViewBag.products = Products;
            //return View(Products);//Strongly Typed Views
            return View();
        }
        public ActionResult Details(int id)
        {
            List<ProductModel> Products = new List<ProductModel>()
            {
                new ProductModel(){ ProductID=101, ProductName="Redmi Note 12 Pro", Rate=50000 },
                new ProductModel(){ ProductID=101, ProductName="Redmi Note 11 Pro", Rate=20000 },
                new ProductModel(){ ProductID=101, ProductName="Redmi Note 10 Pro", Rate=15000 },
            };
            ProductModel matchingProduct=null;
            foreach (var item in Products)
            {
                if (item.ProductID == id)
                {
                    matchingProduct = item;
                }
            }
            ViewBag.MatchingProduct = matchingProduct;
            //return View(matchingProduct);//Strongly Typed Views
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //SHARED VIEWS
        public ActionResult Contact()
        {

            ViewBag.Message = "This is the Home Contact Page";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Create(int ProductID, string ProductName, double Rate)//Normal way
        //public ActionResult Create([Bind(Include = "ProductID, ProductName")]ProductModel P)//Bind Attribute
        //When you want to bind only specific properties
        public ActionResult Create([Bind(Include = "ProductID, ProductName")]ProductModel P)//Model Binding 
        {

            ViewBag.SelectedItems = new List<string> { "In Stock", "Out Of Stock"};
            return View();
        }
        public ActionResult StudentDetails()
        {
            ViewBag.studentid = 1;
            ViewBag.studentname = "Yadynesh";
            ViewBag.studentmarks = 40;
            ViewBag.NoOfSessions = 6;
            ViewBag.Subjects = new List<string> { "Phisycs", "Chemestry", "Maths" };
            return View();
        }
    }
}