using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //throw new StackOverflowException();
            TempData["Filter"] = "myfilter";
            return View();
        }
      
        [ActionName("about-page")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("about");
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Are you stuck? Need help?";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string theMessage)
        {
            // Do something with the message. 
            ViewBag.themessage = "Your query has been sent";
            return View();

        }

        //[Authorize(Users ="dina")]

        public ActionResult Serial(String lettercase)
        {
            var serial = "THISSerial";
            if (lettercase == "lower")
            {
                return Content(serial.ToLower());
            }
             return Content(serial);    
            // return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
          //  return RedirectToAction("index");

        }
           


    }

    public class myFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
      
    }
}