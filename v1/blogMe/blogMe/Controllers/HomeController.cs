﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blogMe.Core.DbContexts;
using blogMe.Core.Model;

namespace blogMe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new BloggingContext();

            return View(db.Blogs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}