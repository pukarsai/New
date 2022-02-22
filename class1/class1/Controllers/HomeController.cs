using Class1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace class1.Controllers
{
    public class HomeController : Controller
    {
        todolistEntities obj = new todolistEntities();
        public ActionResult Index()
        {
            var lst = obj.activityTbls.ToList();
           
            ViewBag.Activity = lst;



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}