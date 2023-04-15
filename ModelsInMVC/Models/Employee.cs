using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsInMVC.Models
{
    public class Employee
    {
        public int id;
        public string name;
        public string email;
         
        public  Employee GetEmployee()
        {
            Employee emp = new Employee() { id=1, name="Namra", email="namra@xxx.com"};
            return emp;
        }

    }
}