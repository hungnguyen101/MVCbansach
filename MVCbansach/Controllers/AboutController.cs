using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCbansach.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _LeftPartPartial()
        {
            return PartialView();
        }
        public PartialViewResult _MiddlePartPartial()
        {
            return PartialView();
        }
    }
}