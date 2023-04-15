﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsInMVC.Models;
namespace ModelsInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 

            Employee dataEmp1 = new Employee().GetEmployee();
            
            return View(dataEmp1);
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