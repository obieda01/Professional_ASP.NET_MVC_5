using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Web.Controllers
{
    public class ColorizedController : Controller
    {
        // GET: Colorized
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult colorizedResult()
        {
            List<string> data = new List<string>();
            ViewBag.FName= Request.Params["Fname"];
            ViewBag.LName = Request.Params["Lname"];

            if (Request.Params["1"].Contains ("true"))
            {
                data.Add("red");
            }
            if (Request.Params["2"].Contains("true"))
            {
                data.Add("blue");
            }
            if (Request.Params["3"].Contains("true"))
            {
                data.Add("green");
            }
            return View("colorizedResult", data);
        }
    }
}