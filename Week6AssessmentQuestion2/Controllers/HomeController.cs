using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week6AssessmentQuestion2.Models;

namespace Week6AssessmentQuestion2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            NorthwindEntities NorthwindDB = new NorthwindEntities();
            List<Order> AllCustomers = NorthwindDB.Orders.ToList();
            ViewBag.EmpList = AllCustomers;
            
            

            return View();
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}