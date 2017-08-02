using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecruitmentWebsite.Controllers
{
    public class HomeController : AppBaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            //ViewBag.Theme = ConfigurationManager.AppSettings["Theme"];
            //if(string.IsNullOrWhiteSpace(ViewBag.Theme))
            //{
            //    ViewBag.Theme = "default";
            //}
            return View();
        }

        public ActionResult Contact()
        {
            var obj = new ViewResult();
            
           ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}