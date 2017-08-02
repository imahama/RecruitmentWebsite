using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecruitmentWebsite.Controllers
{
    public class AppBaseController : Controller
    {
        public AppBaseController()
        {
            ViewBag.Theme = ConfigurationManager.AppSettings["Theme"];
            if (string.IsNullOrWhiteSpace(ViewBag.Theme))
            {
                ViewBag.Theme = "default";
            }
        }
    }
}