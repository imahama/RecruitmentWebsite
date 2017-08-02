using RecruitmentWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RecruitmentWebsite.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index(string NextTab)
        {

            if(string.IsNullOrWhiteSpace(NextTab))
            {
                NextTab = "CreateYourDetails";
            }
            
            //"CreateDemogs", "CreateYourDetails"
            //"CreateYourDetails", "CreateDemogs"
            var model = new RegistrationViewModel() { _ActionNameList = new List<string>() { NextTab},
                 StepIndex = 0
            };

            return View(model);

        }

        [HttpPost]
        public RedirectToRouteResult CreateYourDetails(YourDetailsViewModel yourDetails, string NextTab)
        {
            //call your details service to save data
            //display next tab

            return RedirectToAction("Index", "Registration", new { NextTab });
            //RedirectToAction("Index", new RouteValueDictionary(new { controller = "Registration", action = "Index", NextTab = NextTab }) );
            //RedirectToRoute("Registration", new RouteValueDictionary(new { controller = "Registration", action = "Index", NextTab = NextTab }));
            //Redirect("Registration/Index/CreateDemogs");

            //PartialViewResult result = null;
            //switch(NextTab)
            //{
            //    case "Demogs":
            //        result = PartialView("Demogs", new DemogsViewModel());
            //        break;
            //        default:
            //        break;
            //}
            //return result;
        }

        [ChildActionOnly]
        public PartialViewResult CreateYourDetails()
        {        
            //call your details service
            return PartialView("YourDetails", new YourDetailsViewModel());
        }

        [ChildActionOnly]
        public PartialViewResult CreateDemogs()
        {
            //call demogs service
            return PartialView("Demogs", new DemogsViewModel());
        }
    }
}