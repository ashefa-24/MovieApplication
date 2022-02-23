using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController: Controller
    {
        BoschEntities boschEntity = new BoschEntities();

        //GET : Login
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(EmployeeSDetail su)
        {
            boschEntity.EmployeeSDetails.Add(su);
            boschEntity.SaveChanges();
            return View(su);
        }
    }
}