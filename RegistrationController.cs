using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using REGISTRATION_MODULE.Models;
using REGISTRATION_MODULE.Dataacces;
namespace REGISTRATION_MODULE.Controllers
{
    public class Registration1Controller : Controller
    {
        //
        // GET: /Registration/

        public ActionResult Registration()
        {
            return View();
        }

        [HttpGet]
        public ActionResult insertd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(Register register)
        {
            register.Dateofbirth = Convert.ToDateTime(register.Dateofbirth);
            if (ModelState.IsValid)
            {
                Register obj = new Register();
                string result = obj.insert(register);
                ViewData["result"] = result;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            }
        }
    }
}