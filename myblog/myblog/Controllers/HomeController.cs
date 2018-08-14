using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myblog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BussinesLayer.test test = new BussinesLayer.test();

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}