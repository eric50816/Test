using MVC_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_test.Controllers
{
    public class OperaController : Controller
    {

        private OperaContext context = new OperaContext();

        // GET: Opera
        public ActionResult Index()
        {
            return View(context.Operas.ToList());
        }
    }
}