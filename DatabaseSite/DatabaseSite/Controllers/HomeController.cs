﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseSite.Models;

namespace DatabaseSite.Controllers
{
    [SignIn]
    //[Authorize(Users ="swanscol")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
    }
}