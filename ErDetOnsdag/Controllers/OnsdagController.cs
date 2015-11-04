using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErDetOnsdag.Controllers
{
    public class OnsdagController : Controller
    {
        // GET: Onsdag
        public ActionResult Index()
        {
            string onsdag;
            if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                onsdag = "Ja, og der er onsdagssnegle!";
            }
            else
            {
                onsdag = "Nej, det er " + DateTime.Today.DayOfWeek + ", din hat! Så der er ingen ";
            }
            ViewBag.Onsdag = onsdag;
            return View();
        }
    }
}