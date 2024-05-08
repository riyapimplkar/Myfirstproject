using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myfirstproject.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult index()
        {
            return View();
        }
        public ActionResult Feeddetails()
        {
            return View();
        }
        public ActionResult feedIndex()
        {
            return View();
        }
    }
}