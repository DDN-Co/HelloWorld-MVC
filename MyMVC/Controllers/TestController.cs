using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public string GetString()
        {
            return "Some string ";
        }

        public ActionResult GetView()
        {
            return View("MyView");
        }
	}
}