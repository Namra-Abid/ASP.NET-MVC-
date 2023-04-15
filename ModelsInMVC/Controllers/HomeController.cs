using System;
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

        public ActionResult Student()
        {
            var data = GetStudent();
            return View(data);

        }

        private Student GetStudent()
        {
            return new Student()
            {
                id = 1001,
                name = "Namra",
                course = "English"
            };
        }
        
    }
}