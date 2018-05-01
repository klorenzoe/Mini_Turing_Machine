using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace TuringMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AutomataHelper.fillAutomatas();
            return View();
        }
    }
}