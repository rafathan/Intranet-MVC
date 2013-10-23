using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intranet_MVC.Controllers
{
    public class DepartmentsController : Controller
    {
        //
        // GET: /Departments/

        public ActionResult IT()
        {
            return View();
        }

        public ActionResult HR()
        {
            return View();
        }

        public ActionResult PM()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }
    }
}
