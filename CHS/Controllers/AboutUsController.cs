using CHS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHS.Controllers
{
    public class AboutUsController : Controller
    {
        //Include Database contenxt
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: AboutUs
        public ActionResult Index()
        {
            var contents = db.Contents.ToArray();
            
            ViewBag.topSection = contents[0].ContentDetails;
            ViewBag.middleSection = contents[1].ContentDetails;
            ViewBag.bottomSection = contents[2].ContentDetails;
            return View(contents);
        }
    }
}