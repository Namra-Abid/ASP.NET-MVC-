using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //https://localhost:xxxx/Employee/EmployeeProfile?id=1
        public string EmployeeProfile(int id)
        {
            string profile;
            // string profile =sring.Empty
            if (id == 1)
            {
                profile = "Employee 1";
            }
            else if (id == 2)
            {
                profile = "Employee 2";
            }
            else
            {
                profile = "No record Found !";
            }
            return profile;
        }
        public string EmployeeAddress(int id, string department)
        {
            return "id :" + id + " Department :" + department;
        }
    }
}