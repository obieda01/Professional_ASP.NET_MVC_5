using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("AllReview");
        }

        public ActionResult AllReview()
        {
            IReviewDAL allReviews = new ReviewSqlDAL();

            return View("AllReview", allReviews.GetAllReviews());
        }

        public ActionResult NewReview()
        {
            if (!String.IsNullOrEmpty(Request.Params["username"]))
            {
                IReviewDAL addReview = new ReviewSqlDAL();
                Review newReview = new Review();
                newReview.Username = (Request.Params["username"]);
                newReview.Rating = int.Parse(Request.Params["rate"]);
                newReview.Title = (Request.Params["title"]);
                newReview.Message = (Request.Params["review"]);
                newReview.ReviewDate = DateTime.UtcNow;
                addReview.SaveReview(newReview);
                return RedirectToAction("AllReview");

            }
            else
            {
                return View("NewReview");
            }
        }
    }
}