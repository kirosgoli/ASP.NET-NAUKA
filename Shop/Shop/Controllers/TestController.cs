using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            return Content("Witaj!");
        }
        public ActionResult Hello(string id)
        {
            return View();
        }
    }
}