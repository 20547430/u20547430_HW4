using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20547430_HW4.Models;

namespace u20547430_HW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Pastpaper()
        {
            
            return View(ListRepository.pastPapers);
        }

        public ActionResult StudyGuide()
        {

            return View(ListRepository.pastPapers);
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