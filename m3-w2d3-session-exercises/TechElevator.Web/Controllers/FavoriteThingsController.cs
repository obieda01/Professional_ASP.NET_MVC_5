using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechElevator.Web.Controllers
{
    public class FavoriteThingsController : Controller
    {
        // GET: FavoriteThings
        public ActionResult Index()
        {
            return RedirectToAction("Page1");
        }

        // GET: FavoriteThings/Page1
        public ActionResult Page1()
        {
            Session["color"] = "Favorite Color: " + Request.Params["Answer"];
            return View();
        }

        // GET: FavoriteThings/Page2
        public ActionResult Page2()
        {
            Session["color"] = "Favorite Color: " + Request.Params["Answer"];
            return View();
        }

        // GET: FavoriteThings/Page3
        public ActionResult Page3()
        {
            Session["Food"] = "Favorite Food: " + Request.Params["Answer"];
            return View();
        }


        // GET: FavoriteThings/Page3
        public ActionResult Summary()
        {
            Session["season"] = "Favorite Season: " + Request.Params["season"];
            return View();
        }

    }
}