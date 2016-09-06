﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patient_History.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Patient Database Application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "MUHIBBUR RAHMAN.";

            return View();
        }
    }
}