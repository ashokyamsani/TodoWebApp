using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoWebAapp.Controllers
{
    public class MyTestController : Controller
    {
        // GET: MyTest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyTest(int intTestVar)
        {
            return View("MyTest");
        }
    }
}