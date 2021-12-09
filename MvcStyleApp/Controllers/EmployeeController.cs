using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStyleApp.Models;

namespace MvcStyleApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Home(Employee e)
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}