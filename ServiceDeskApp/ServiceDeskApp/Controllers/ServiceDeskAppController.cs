using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceDeskApp.Controllers
{
    public class ServiceDeskAppController : Controller
    {
        //
        // GET: /ServiceDeskApp/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult address()
        {
            return View();
        }
        public ActionResult organization()
        {
            return View();
        }
        public ActionResult person()
        {
            return View();
        }

    }
}
