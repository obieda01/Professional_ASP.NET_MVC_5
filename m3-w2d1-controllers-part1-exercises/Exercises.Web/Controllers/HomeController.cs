using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View("xOrdered");
        }
        public ActionResult xOrdered()
        {
            return View("xOrdered");
        }

        public ActionResult xOrderedResult()
        {
            List<string> data = new List<string>();
            data.Add("First Name:" +Request.Params["Fname"]);
            data.Add("Mid Name:" + Request.Params["Mname"]);
            data.Add("Last Name:" + Request.Params["Lname"]);
            if(Request.Params["1"]== "First MI Last")
            {
                data.Add("Ordered: " + Request.Params["Fname"]+ Request.Params["Mname"]+ Request.Params["Lname"]);

            }
            else
            {
                data.Add("sasa");
            }

            return View("xOrderedResult",data);
        }
        
    }
}