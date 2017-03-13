using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Web.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View("FizzBuzzRevisited");
        }

        public ActionResult FizzBuzzRevisited()
        {
            List<string> numberList = new List<string>();
            numberList.Add("Divisable by :" + Request.Params["div_by_1"]);
            numberList.Add("Divisable by :" + Request.Params["div_by_2"]);
            numberList.Add("Divisable by both :" + Request.Params["div_by_1"] + "and" +
                Request.Params["div_by_2"]);
            numberList.Add("Alternative Fizz:" + Request.Params["al_fizz"]);
            numberList.Add("Alternative bizz:" + Request.Params["al_buzz"]);

            for (int i = 1; i <5; i++)
            {
                try
                {

                    string si = i.ToString();
                    if (int.Parse(Request.Params["num_" + si]) % int.Parse(Request.Params["div_by_1"]) == 0 &&
                        int.Parse(Request.Params["num_" + si]) % int.Parse(Request.Params["div_by_2"]) == 0)
                    {
                        numberList.Add(Request.Params["num_" + si] + " " + Request.Params["al_buzz"] +
                        Request.Params["al_fizz"]);
                    }
                    else if (int.Parse(Request.Params["num_" + si]) % int.Parse(Request.Params["div_by_1"]) == 0)
                    {
                        numberList.Add(Request.Params["num_" + si] + " " +
                        Request.Params["al_fizz"]);
                    }
                    else if (int.Parse(Request.Params["num_" + si]) % int.Parse(Request.Params["div_by_2"]) == 0)
                    {
                        numberList.Add(Request.Params["num_" + si] + " " +
                        Request.Params["al_buzz"]);
                    }
                    else
                    {
                        numberList.Add(Request.Params["num_" + si] + " ");
                    }
                }
                catch (Exception)
                {
                    return View("FizzBuzzRevisited");

                }
            }

            return View("FizzBuzzRevisitedResult", numberList);
        }

        public string FizzBuzz(string number)
        {
            return "";
        }
    }
}