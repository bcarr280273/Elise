﻿using System.Web.Mvc;

namespace MvcTwitterBootstrap.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Examples()
        {
            return View();
        }
    }
}
